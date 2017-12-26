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
            listItem = new List<DetectedItem>();
        }

        VideoCapture video;
        CascadeClassifier cascadeClassifier;
        Timer timer;
        bool isPlaying;
        bool isDetecting;
        int carCount;

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
            timer.Interval = trackbarInterval.Value;
            timer.Tick += process;
            timer.Start();
            isPlaying = false;
            isDetecting = false;
            carCount = 0;
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
                trackBarLaneX.Maximum = trackbarLaneWidth.Maximum = video.Width;
                trackBarLaneY.Maximum = trackbarLaneHeight.Maximum = video.Height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
        }

        private void trackbarInterval_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = trackbarInterval.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isDetecting = !isDetecting;
        }
    }
}
