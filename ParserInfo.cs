using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UrlFind
{
    public class ParserInfo
    {
        public int ActiveThreads;
        public int Level;
        public int TotalUrl;
        public int CurrentUrl;

        public override string ToString()
        {
            var result = string.Format("ActiveThreads: {0}" + Environment.NewLine, ActiveThreads);
            result += string.Format("Level: {0}" + Environment.NewLine, Level);
            result += string.Format("Parsing: {0} of {1}" + Environment.NewLine, CurrentUrl, TotalUrl);
      
            return result;
        }
    }
}
