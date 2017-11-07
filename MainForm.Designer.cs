namespace UrlFind
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.logMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblMaxThreads = new System.Windows.Forms.Label();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.lblMaxDepth = new System.Windows.Forms.Label();
            this.tbSearchText = new System.Windows.Forms.TextBox();
            this.numMaxThreads = new System.Windows.Forms.NumericUpDown();
            this.numMaxDepth = new System.Windows.Forms.NumericUpDown();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.logMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(93, 95);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnStop.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(207, 95);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 33);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtLog
            // 
            this.txtLog.ContextMenuStrip = this.logMenu;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Location = new System.Drawing.Point(0, 218);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(636, 143);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = " - Output info -";
            // 
            // logMenu
            // 
            this.logMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.logMenu.Name = "logMenu";
            this.logMenu.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(93, 31);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(330, 20);
            this.tbUrl.TabIndex = 4;
            this.tbUrl.Text = "http://olx.ua";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(67, 34);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(20, 13);
            this.lblUrl.TabIndex = 5;
            this.lblUrl.Text = "Url";
            // 
            // lblMaxThreads
            // 
            this.lblMaxThreads.AutoSize = true;
            this.lblMaxThreads.Location = new System.Drawing.Point(459, 33);
            this.lblMaxThreads.Name = "lblMaxThreads";
            this.lblMaxThreads.Size = new System.Drawing.Size(69, 13);
            this.lblMaxThreads.TabIndex = 6;
            this.lblMaxThreads.Text = "Max Threads";
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Location = new System.Drawing.Point(25, 60);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(62, 13);
            this.lblSearchText.TabIndex = 7;
            this.lblSearchText.Text = "SearchText";
            // 
            // lblMaxDepth
            // 
            this.lblMaxDepth.AutoSize = true;
            this.lblMaxDepth.Location = new System.Drawing.Point(469, 55);
            this.lblMaxDepth.Name = "lblMaxDepth";
            this.lblMaxDepth.Size = new System.Drawing.Size(59, 13);
            this.lblMaxDepth.TabIndex = 8;
            this.lblMaxDepth.Text = "Max Depth";
            // 
            // tbSearchText
            // 
            this.tbSearchText.Location = new System.Drawing.Point(93, 57);
            this.tbSearchText.Name = "tbSearchText";
            this.tbSearchText.Size = new System.Drawing.Size(199, 20);
            this.tbSearchText.TabIndex = 9;
            this.tbSearchText.Text = "any text";
            // 
            // numMaxThreads
            // 
            this.numMaxThreads.Location = new System.Drawing.Point(557, 31);
            this.numMaxThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxThreads.Name = "numMaxThreads";
            this.numMaxThreads.Size = new System.Drawing.Size(52, 20);
            this.numMaxThreads.TabIndex = 10;
            this.numMaxThreads.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numMaxDepth
            // 
            this.numMaxDepth.Location = new System.Drawing.Point(557, 53);
            this.numMaxDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxDepth.Name = "numMaxDepth";
            this.numMaxDepth.Size = new System.Drawing.Size(52, 20);
            this.numMaxDepth.TabIndex = 11;
            this.numMaxDepth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInfo.Location = new System.Drawing.Point(0, 140);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(636, 78);
            this.txtInfo.TabIndex = 12;
            this.txtInfo.Text = "-Info-";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 361);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.numMaxDepth);
            this.Controls.Add(this.numMaxThreads);
            this.Controls.Add(this.tbSearchText);
            this.Controls.Add(this.lblMaxDepth);
            this.Controls.Add(this.lblSearchText);
            this.Controls.Add(this.lblMaxThreads);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.logMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblMaxThreads;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.Label lblMaxDepth;
        private System.Windows.Forms.TextBox tbSearchText;
        private System.Windows.Forms.NumericUpDown numMaxThreads;
        private System.Windows.Forms.NumericUpDown numMaxDepth;
        private System.Windows.Forms.ContextMenuStrip logMenu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtInfo;
    }
}

