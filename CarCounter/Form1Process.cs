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
    public class DetectedItem
    {
        private Rectangle rect;
        private uint atFrame;

        public DetectedItem(Rectangle rect, uint atFrame)
        {
            this.rect = rect;
            this.atFrame = atFrame;
        }

        public uint AtFrame
        {
            get
            {
                return atFrame;
            }

            set
            {
                atFrame = value;
            }
        }

        public Rectangle Rect
        {
            get
            {
                return rect;
            }

            set
            {
                rect = value;
            }
        }
    }
    public partial class frmMain : Form
    {
        
        Mat prevFrame;
        static int detectionHeight = 10;
        uint framecount =0;
        List<DetectedItem> listItem;
        private void process(object sender, EventArgs e)
        {
            if (video == null || cascadeClassifier == null)
            {
                statLabel.Text = "No video and/or haar cascades file";
                return;
            }
            if (!isPlaying)
            {
                statLabel.Text = "Click Play";
                return;
            }
            using (Mat imgFrame = video.QueryFrame())
            {
                if (imgFrame == null)
                {
                    video.SetCaptureProperty(CapProp.PosAviRatio, 0);
                    return;
                }
                using (Image<Bgr, byte> output = imgFrame.ToImage<Bgr, byte>())
                {
                    //draw detection lane
                    Rectangle detectionLane = new Rectangle(trackBarLaneX.Value, trackBarLaneY.Value, trackbarLaneWidth.Value, trackbarLaneHeight.Value);
                    output.Draw(detectionLane, new Bgr(Color.Green), 1);
                    Rectangle countLane;
                    if (cbIncoming.Checked)
                    {
                        countLane = new Rectangle(
                            detectionLane.Left,
                            detectionLane.Bottom-detectionHeight,
                            detectionLane.Width,
                            detectionHeight
                        );
                    }
                    else
                    {
                        countLane = new Rectangle(
                                                detectionLane.Left,
                                                detectionLane.Top,
                                                detectionLane.Width,
                                                detectionHeight
                        );
                    }
                    //draw detection obj
                    if (isDetecting)
                    {
                        //draw how many cars counted
                        output.Draw($"Cars: {listItem.Count}", new Point(0, video.Height), FontFace.HersheyPlain, 2.5, new Bgr(Color.Red));
                        if (Helper.RectArea(detectionLane) > 1)
                        {
                            Rectangle[] rects = cascadeClassifier.DetectMultiScale(output.Mat, 1.1, 1);
                            foreach (Rectangle rect in rects)
                            {
                                Point middle = Helper.RectToPoint(rect);
                                output.Draw(new CircleF(middle, 1), new Bgr(Color.Blue), 2);
                                if (detectionLane.Contains(middle))
                                {
                                    output.Draw(rect, new Bgr(Color.Red), 1);
                                    if (countLane.Contains(middle))
                                    {
                                        if (!Helper.AlreadyDetected(rect, listItem, framecount))
                                        {
                                            output.Draw(countLane, new Bgr(Color.Yellow), 2);
                                            listItem.Add(new DetectedItem(rect, framecount));
                                        }
                                    }
                                }

                            }
                        }
                    }
                    else
                        output.Draw(countLane, new Bgr(Color.Yellow), 2);
                    ibMonitor.Image = output;
                }
                //status update
                var max = video.GetCaptureProperty(CapProp.FrameCount);
                var now = video.GetCaptureProperty(CapProp.PosFrames);
                statLabel.Text = $"Position: {now}/{max}";
                //save img to previmg
                prevFrame = imgFrame;
                framecount++;
            }
        }
    }
}
