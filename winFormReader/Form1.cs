using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace winFormReader
{
    public partial class Form1 : Form
    {
        public SpeechSynthesizer voice;
        private string path = "";
        private string fileName = "";
        
        public Form1()
        {
            InitializeComponent();
            this.voice = new SpeechSynthesizer();
            this.voice.Rate = -1;
            this.voice.Volume = 100;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (this.path == "")
            {
                MessageBox.Show("请先选择文件");
                return;
            }
            this.Speech();
        }
        public void Speech()
        {
            this.voice.SpeakAsync("你好，请朗诵这段文字。hello，read these words please!");
        }

        private void stop_Click(object sender, EventArgs e)
        {
            this.voice.Pause();
        }

        private void goOn_Click(object sender, EventArgs e)
        {
             this.voice.Resume();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            this.Speech();
        }

        
        private void voiceTrackBar_Scroll(object sender, EventArgs e)
        {
            this.voice.Volume = voiceTraceBar.Value;
        }

        private void speedTraceBar_Scroll(object sender, EventArgs e)
        {
            this.voice.Rate = speedTraceBar.Value;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            ofd.Filter = "文本文件(*.txt)|*.txt";
            this.path = ofd.FileName;
            this.fileName = ofd.FileNames[0];
            txtFileName.Text = this.fileName;
            Console.Write(this.path);
        }
    }
}
