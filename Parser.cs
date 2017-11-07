using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UrlFind
{
    public class Parser
    {
        public int MaxDepth;

        public delegate void MethodContainer(string text);
        public delegate void AtivityChanged();
        public event MethodContainer LogEvent;
        public event AtivityChanged ActivityEvent;

        public string StartUrl;
        public string SearchText;
        public bool IsActive { 
                get { 
                    return _isActive; 
                } 
                private set { 
                        _isActive = value;
                        if (ActivityEvent!= null)
                            ActivityEvent.BeginInvoke(null, null);  
                } 
        } 
        private bool _isActive;

     
        public int MaxThreads;
        private int _currentLevel;
        private int _activeThreads;
        private int _currentUrl;
        //public int _totalUrl;
        
        ConcurrentDictionary<int, List<string>> listUrl;
        ConcurrentBag<string> unicUrl;

        public void Init(int maxThreads, int maxDepth, string startUrl, string searchText)
        {
            ThreadPool.SetMaxThreads(maxThreads, maxThreads);
            MaxDepth = maxDepth;
            MaxThreads = maxThreads;
            StartUrl = startUrl;
            SearchText = searchText;
           
            _currentLevel = 0;
            _currentUrl = 0;
          //  _totalUrl = 0;
            listUrl = new ConcurrentDictionary<int, List<string>>();  // level, List<Url>
            unicUrl = new ConcurrentBag<string>();

            Log("parser init:{0} threads, {1} depth", maxThreads, maxDepth);
        }

        private void Log(string text, params object[] param) {

            if (param != null)
                text = string.Format(text, param);

            if(LogEvent != null)
                LogEvent.BeginInvoke(text, null, null);

        }

        public void StartParse() {
       
            if (string.IsNullOrEmpty(StartUrl) || string.IsNullOrEmpty(SearchText)) 
                return;

            IsActive = true;
          

            listUrl.TryAdd(0, new List<string> { StartUrl});
         
            for (int i = 0; i < MaxDepth; i++) {
                _currentLevel = i;

                if (!IsActive)
                    break;

                GetLinks();
            }

            IsActive = false;

        }

        public void GetLinks() {

            _currentUrl = 0;
            List<string> urlList; // список URL для текущего уровня
            listUrl.TryGetValue(_currentLevel, out urlList);

            ParallelOptions options = new ParallelOptions();
            ParallelLoopResult loopResult = Parallel.For(
                    0,
                    urlList.Count,
                    options,
                    (i, loopState) =>
                    {
                        _activeThreads++;
                        _currentUrl++;
                        if (!IsActive) 
                            return;

                        string html = GetHtml(urlList[i]);

                        if (html.Contains(SearchText)) {
                            Log("Found text on url:{0}, Level:{1}", urlList[i], _currentLevel);
                            IsActive = false;
                            return;
                        }
                            
                        var activeLink = GetActiveHref(html);
                        listUrl.TryAdd(_currentLevel + 1, activeLink);

                        _activeThreads--;
                       
                    }
                );
          

        }

        private List<string> GetActiveHref(string html) {

            var hrefList = new List<string>();

            if (string.IsNullOrEmpty(html))
                return hrefList;
            
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var nodeList = doc.DocumentNode.SelectNodes("//a");
            foreach (var node in nodeList) {
                if (node.Attributes["href"] != null) { 
                    
                    string newUrl = node.Attributes["href"].Value;
                    if (ValidUrl(newUrl) && !unicUrl.Contains(newUrl)){
                        unicUrl.Add(newUrl);
                        hrefList.Add(newUrl);
                    }
                  
                }
                   
            }
            return hrefList;
                
        }

        public bool ValidUrl(string url) {
            return 
                !string.IsNullOrEmpty(url) 
                && Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute)
                && url.StartsWith("http");
        }

        private string GetHtml(string adress)
        {
            string _content = string.Empty;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(adress);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == null)
                        readStream = new StreamReader(receiveStream);
                    else
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

                    _content = readStream.ReadToEnd();

                    response.Close();
                    readStream.Close();
                }
            }
            catch (Exception e) {
                Log("Can't get url:{0}, Error:{1}", adress, e.Message.Substring(0,50));
            }

            return _content;
        }


        public void StopParse() {
            IsActive = false;
        }

        public void PauseParse() { 
        
        }

        public ParserInfo GetInfo() {
            var info = new ParserInfo();
            info.ActiveThreads = _activeThreads;
            info.Level = _currentLevel;
            info.TotalUrl = listUrl[_currentLevel].Count;
            info.CurrentUrl = _currentUrl;
            return info;
        }

       
    }
}
