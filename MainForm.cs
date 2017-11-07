using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrlFind
{
    

    public partial class MainForm : Form
    {
        private object objLock = new object();
        private Parser parser = new Parser();
        private System.Windows.Forms.Timer _timer;
        Thread _thread;

        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            parser.LogEvent += Log;
            parser.ActivityEvent += ActivityEvent;

            init(); 
        }
    
        private void init() {
            btnStop.Enabled = false;

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_UpdateInfo;
        }

        private void Timer_UpdateInfo(object sender, EventArgs e)
        {
            var res =  parser.GetInfo();
            txtInfo.Text = res.ToString();
        }


        public void Log(string text) {
            lock (objLock)
                txtLog.AppendText(text + Environment.NewLine);
        }

        public void ActivityEvent() {
            UpdateButtons();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (!parser.IsActive)
            {
                txtLog.Clear();
                _timer.Start();
                Log("Start...");

                int maxThreads = (int)numMaxThreads.Value;
                int maxDepth = (int)numMaxDepth.Value;

                _thread = new Thread(() => {
                    parser.Init(maxThreads, maxDepth, tbUrl.Text, tbSearchText.Text);    
                    parser.StartParse();
                });
                _thread.IsBackground = true;
                _thread.Start();

                
            }
            else {
                parser.PauseParse();
            }
           

        }

        private void UpdateButtons()
        {
            btnStop.Enabled = parser.IsActive;
            btnStart.Text = !parser.IsActive ? "Start" : "Pause";
            btnStart.BackColor = !parser.IsActive ? Color.FromArgb(192, 255, 192) : Color.FromArgb(255, 255, 0);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Log("Stop...");
            parser.StopParse();
            _timer.Stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Log("Pause...");
            parser.PauseParse();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

     

    }
}
