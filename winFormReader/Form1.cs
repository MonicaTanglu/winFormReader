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
using System.IO;
using System.Threading;


namespace winFormReader
{
    public partial class Form1 : Form
    {
        public SpeechSynthesizer voice;
        private string path = "";
        private string fileName = "";
        private long size = 0;
        
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
            }else
            {
                Thread thread = new Thread(new ThreadStart(this.Speech));

                thread.Start();
                //Console.ReadKey();
            }
            
        }
        public void Speech()
        {
            byte[] byData = new byte[400];
            char[] charData = new char[100];
            int start = 0;
            try
            {
                FileStream file = new FileStream(this.path, FileMode.Open);
                long size = file.Length + byData.Length;
                Json txtJson = new Json();
                //string sIndex = txtJson.getJson();
                string sIndex = txtJson.readJson(this.path);
                long rIndex = start;
                if (sIndex != null) rIndex = Convert.ToInt64(sIndex);

                while (rIndex < size)
                {

                    //txtJson.setJson(rIndex.ToString());
                    txtJson.writeJson(this.path, rIndex.ToString());
                    file.Seek(rIndex, SeekOrigin.Current);
                    int length = file.Read(byData, 0, byData.Length);
                    string str = System.Text.Encoding.Default.GetString(byData);

                    this.voice.Speak(str);
                    start += byData.Length;
                    rIndex = start;


                }
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);

            }
            
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
            // this.Speech();
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
