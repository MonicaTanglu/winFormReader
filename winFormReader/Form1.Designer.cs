namespace winFormReader
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.goOn = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.speedTraceBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.voiceTraceBar = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fileShow = new System.Windows.Forms.RadioButton();
            this.fileHiden = new System.Windows.Forms.RadioButton();
            this.txtFileName = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTraceBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiceTraceBar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(131, 25);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.confirm_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(25, 25);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "暂停";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // goOn
            // 
            this.goOn.Location = new System.Drawing.Point(25, 75);
            this.goOn.Name = "goOn";
            this.goOn.Size = new System.Drawing.Size(75, 23);
            this.goOn.TabIndex = 2;
            this.goOn.Text = "继续";
            this.goOn.UseVisualStyleBackColor = true;
            this.goOn.Click += new System.EventHandler(this.goOn_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(131, 75);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.goOn);
            this.panel1.Location = new System.Drawing.Point(371, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 132);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.speedTraceBar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.voiceTraceBar);
            this.panel2.Location = new System.Drawing.Point(28, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 132);
            this.panel2.TabIndex = 5;
            // 
            // speedTraceBar
            // 
            this.speedTraceBar.Location = new System.Drawing.Point(82, 75);
            this.speedTraceBar.Minimum = -10;
            this.speedTraceBar.Name = "speedTraceBar";
            this.speedTraceBar.Size = new System.Drawing.Size(149, 45);
            this.speedTraceBar.TabIndex = 3;
            this.speedTraceBar.Value = -1;
            this.speedTraceBar.Scroll += new System.EventHandler(this.speedTraceBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "语速：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "音量：";
            // 
            // voiceTraceBar
            // 
            this.voiceTraceBar.Location = new System.Drawing.Point(82, 12);
            this.voiceTraceBar.Maximum = 100;
            this.voiceTraceBar.Name = "voiceTraceBar";
            this.voiceTraceBar.Size = new System.Drawing.Size(149, 45);
            this.voiceTraceBar.TabIndex = 0;
            this.voiceTraceBar.Value = 100;
            this.voiceTraceBar.Scroll += new System.EventHandler(this.voiceTrackBar_Scroll);
            this.voiceTraceBar.ValueChanged += new System.EventHandler(this.voiceTrackBar_Scroll);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtFileName);
            this.panel3.Controls.Add(this.fileHiden);
            this.panel3.Controls.Add(this.fileShow);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.openFile);
            this.panel3.Location = new System.Drawing.Point(38, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 160);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(18, 25);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "打开文件";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(116, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 1;
            // 
            // fileShow
            // 
            this.fileShow.AutoSize = true;
            this.fileShow.Location = new System.Drawing.Point(21, 79);
            this.fileShow.Name = "fileShow";
            this.fileShow.Size = new System.Drawing.Size(47, 16);
            this.fileShow.TabIndex = 2;
            this.fileShow.TabStop = true;
            this.fileShow.Text = "显示";
            this.fileShow.UseVisualStyleBackColor = true;
            // 
            // fileHiden
            // 
            this.fileHiden.AutoSize = true;
            this.fileHiden.Location = new System.Drawing.Point(98, 79);
            this.fileHiden.Name = "fileHiden";
            this.fileHiden.Size = new System.Drawing.Size(47, 16);
            this.fileHiden.TabIndex = 3;
            this.fileHiden.TabStop = true;
            this.fileHiden.Text = "隐藏";
            this.fileHiden.UseVisualStyleBackColor = true;
            // 
            // txtFileName
            // 
            this.txtFileName.AutoSize = true;
            this.txtFileName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFileName.Location = new System.Drawing.Point(99, 29);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(72, 16);
            this.txtFileName.TabIndex = 4;
            this.txtFileName.Text = "天天向上";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTraceBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiceTraceBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button goOn;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar speedTraceBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar voiceTraceBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton fileHiden;
        private System.Windows.Forms.RadioButton fileShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label txtFileName;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

