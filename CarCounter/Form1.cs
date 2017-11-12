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

namespace CarCounter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        VideoCapture video;
        CascadeClassifier cascadeClassifier;
        Timer timer;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCascade.Text = "";
            lblVideo.Text = "";
            //open file evt
            btnOpenVideo.Click += openVideo;
            tsOpenVideo.Click += openVideo;
            btnOpenCascade.Click += openCascade;
            tsOpenCascade.Click += openCascade;
            timer = new Timer();
            timer.Interval = 65;
            timer.Tick += process;
            timer.Start();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void process(object sender, EventArgs e)
        {
            if (video == null || cascadeClassifier == null)
            {
                statLabel.Text = "No video and/or haar cascades file";
                return;
            }
            using (Mat imgFrame = video.QueryFrame())
            {
                if (imgFrame == null)
                {
                    video.SetCaptureProperty(CapProp.PosAviRatio, 0);
                    return;
                }
                Rectangle[] rects = cascadeClassifier.DetectMultiScale(imgFrame, 1.1, 1/*, default(Size), gray.Size*/);
                using(Image<Bgr, byte> output = imgFrame.ToImage<Bgr, byte>())
                {
                    foreach (Rectangle rect in rects)
                    {
                        output.Draw(rect, new Bgr(Color.Red), 3);
                    }
                    ibMonitor.Image = output;
                }
                //status update
                var max = video.GetCaptureProperty(CapProp.FrameCount);
                var now = video.GetCaptureProperty(CapProp.PosFrames);
                statLabel.Text = $"Position: {now}/{max}";
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
