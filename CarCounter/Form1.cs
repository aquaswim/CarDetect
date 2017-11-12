using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.Diagnostics;

namespace CarCounter
{
    public partial class frmMain : Form
    {
        Stopwatch stopwatch;
        public frmMain()
        {
            InitializeComponent();
        }

        VideoCapture video;
        CascadeClassifier cascadeClassifier;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCascade.Text = "";
            lblVideo.Text = "";
            stopwatch = new Stopwatch();
            //open file evt
            btnOpenVideo.Click += openVideo;
            tsOpenVideo.Click += openVideo;
            btnOpenCascade.Click += openCascade;
            tsOpenCascade.Click += openCascade;
        }

        private void openVideo(object sender, EventArgs e)
        {
            try
            {
                ofdOpenFIle.FileName = "";
                if (ofdOpenFIle.ShowDialog() != DialogResult.OK || ofdOpenFIle.FileName == "")
                    throw new Exception("No Video File Opened.");
                video = new VideoCapture(ofdOpenFIle.FileName);
                lblVideo.Text = ofdOpenFIle.FileName;
                start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void start()
        {
            if (video != null && (cascadeClassifier != null))
            {
                Application.Idle += process;
                stopwatch.Start();
            }
        }
        int nFrame = 0;
        private void process(object sender, EventArgs e)
        {
            using(Mat imgFrame = video.QueryFrame())
            {
                if (imgFrame == null)
                {
                    Application.Idle -= process;
                    video.Dispose();
                    statLabel.Text = "Video END";
                    stopwatch.Stop();
                    return;
                }
                using(Mat gray=new Mat(imgFrame.Size,DepthType.Cv8U,1))
                {
                    CvInvoke.CvtColor(imgFrame, gray, ColorConversion.Bgr2Gray);
                    Rectangle[] rects = cascadeClassifier.DetectMultiScale(gray, 1.1, 1/*, default(Size), gray.Size*/);
                    using(Image<Bgr, byte> output = imgFrame.ToImage<Bgr, byte>())
                    {
                        foreach (Rectangle rect in rects)
                        {
                            output.Draw(rect, new Bgr(Color.Red), 3);
                        }
                        ibMonitor.Image = output;
                        nFrame++;
                        if (stopwatch.ElapsedMilliseconds > 1000)
                        {
                            statLabel.Text = $"{nFrame/ stopwatch.Elapsed.Seconds} FPS";
                            nFrame = 0;
                            stopwatch.Reset();
                        }
                    }
                }
            }
        }

        private void openCascade(object sender, EventArgs e)
        {
            try
            {
                ofdOpenFIle.FileName = "";
                if (ofdOpenFIle.ShowDialog() != DialogResult.OK || ofdOpenFIle.FileName == "")
                    throw new Exception("No Cascade File Opened.");
                cascadeClassifier = new CascadeClassifier(ofdOpenFIle.FileName);
                lblCascade.Text = ofdOpenFIle.FileName;
                start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
