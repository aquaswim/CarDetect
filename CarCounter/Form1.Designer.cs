namespace CarCounter
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.scSideBar = new System.Windows.Forms.SplitContainer();
            this.tblFilePanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblCascade = new System.Windows.Forms.Label();
            this.btnOpenCascade = new System.Windows.Forms.Button();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.lblVideo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackbarInterval = new System.Windows.Forms.TrackBar();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStartDetect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarLaneY = new System.Windows.Forms.TrackBar();
            this.trackbarLaneWidth = new System.Windows.Forms.TrackBar();
            this.trackbarLaneHeight = new System.Windows.Forms.TrackBar();
            this.trackBarLaneX = new System.Windows.Forms.TrackBar();
            this.ibMonitor = new Emgu.CV.UI.ImageBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOpenVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOpenCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdOpenFIle = new System.Windows.Forms.OpenFileDialog();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.statLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbIncoming = new System.Windows.Forms.CheckBox();
            this.tblMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSideBar)).BeginInit();
            this.scSideBar.Panel1.SuspendLayout();
            this.scSideBar.Panel2.SuspendLayout();
            this.scSideBar.SuspendLayout();
            this.tblFilePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLaneY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarLaneWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarLaneHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLaneX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibMonitor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMainPanel
            // 
            this.tblMainPanel.ColumnCount = 2;
            this.tblMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tblMainPanel.Controls.Add(this.scSideBar, 1, 0);
            this.tblMainPanel.Controls.Add(this.ibMonitor, 0, 0);
            this.tblMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainPanel.Location = new System.Drawing.Point(0, 24);
            this.tblMainPanel.Name = "tblMainPanel";
            this.tblMainPanel.RowCount = 1;
            this.tblMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 537F));
            this.tblMainPanel.Size = new System.Drawing.Size(784, 537);
            this.tblMainPanel.TabIndex = 0;
            // 
            // scSideBar
            // 
            this.scSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSideBar.Location = new System.Drawing.Point(577, 3);
            this.scSideBar.Name = "scSideBar";
            this.scSideBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scSideBar.Panel1
            // 
            this.scSideBar.Panel1.Controls.Add(this.tblFilePanel);
            // 
            // scSideBar.Panel2
            // 
            this.scSideBar.Panel2.Controls.Add(this.groupBox2);
            this.scSideBar.Panel2.Controls.Add(this.btnStartDetect);
            this.scSideBar.Size = new System.Drawing.Size(204, 531);
            this.scSideBar.SplitterDistance = 228;
            this.scSideBar.TabIndex = 0;
            // 
            // tblFilePanel
            // 
            this.tblFilePanel.ColumnCount = 2;
            this.tblFilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tblFilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFilePanel.Controls.Add(this.lblCascade, 1, 1);
            this.tblFilePanel.Controls.Add(this.btnOpenCascade, 0, 1);
            this.tblFilePanel.Controls.Add(this.btnOpenVideo, 0, 0);
            this.tblFilePanel.Controls.Add(this.lblVideo, 1, 0);
            this.tblFilePanel.Controls.Add(this.groupBox1, 0, 2);
            this.tblFilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilePanel.Location = new System.Drawing.Point(0, 0);
            this.tblFilePanel.Name = "tblFilePanel";
            this.tblFilePanel.RowCount = 3;
            this.tblFilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tblFilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tblFilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblFilePanel.Size = new System.Drawing.Size(202, 226);
            this.tblFilePanel.TabIndex = 0;
            // 
            // lblCascade
            // 
            this.lblCascade.AutoSize = true;
            this.lblCascade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCascade.Location = new System.Drawing.Point(71, 58);
            this.lblCascade.Name = "lblCascade";
            this.lblCascade.Size = new System.Drawing.Size(128, 58);
            this.lblCascade.TabIndex = 3;
            this.lblCascade.Text = "label1";
            this.lblCascade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOpenCascade
            // 
            this.btnOpenCascade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenCascade.Location = new System.Drawing.Point(3, 68);
            this.btnOpenCascade.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnOpenCascade.Name = "btnOpenCascade";
            this.btnOpenCascade.Size = new System.Drawing.Size(62, 38);
            this.btnOpenCascade.TabIndex = 1;
            this.btnOpenCascade.Text = "Open Cascade";
            this.btnOpenCascade.UseVisualStyleBackColor = true;
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenVideo.Location = new System.Drawing.Point(3, 10);
            this.btnOpenVideo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(62, 38);
            this.btnOpenVideo.TabIndex = 0;
            this.btnOpenVideo.Text = "Open Video";
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVideo.Location = new System.Drawing.Point(71, 0);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(128, 58);
            this.lblVideo.TabIndex = 2;
            this.lblVideo.Text = "label1";
            this.lblVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.tblFilePanel.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackbarInterval);
            this.groupBox1.Controls.Add(this.btnPlayPause);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interval";
            // 
            // trackbarInterval
            // 
            this.trackbarInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackbarInterval.Location = new System.Drawing.Point(6, 71);
            this.trackbarInterval.Maximum = 250;
            this.trackbarInterval.Minimum = 1;
            this.trackbarInterval.Name = "trackbarInterval";
            this.trackbarInterval.Size = new System.Drawing.Size(184, 45);
            this.trackbarInterval.TabIndex = 1;
            this.trackbarInterval.Value = 65;
            this.trackbarInterval.ValueChanged += new System.EventHandler(this.trackbarInterval_ValueChanged);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlayPause.Location = new System.Drawing.Point(61, 19);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(82, 23);
            this.btnPlayPause.TabIndex = 0;
            this.btnPlayPause.Text = "Play/Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbIncoming);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackBarLaneY);
            this.groupBox2.Controls.Add(this.trackbarLaneWidth);
            this.groupBox2.Controls.Add(this.trackbarLaneHeight);
            this.groupBox2.Controls.Add(this.trackBarLaneX);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 204);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detection Lane Adjustment";
            // 
            // btnStartDetect
            // 
            this.btnStartDetect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartDetect.Location = new System.Drawing.Point(50, 247);
            this.btnStartDetect.Name = "btnStartDetect";
            this.btnStartDetect.Size = new System.Drawing.Size(111, 29);
            this.btnStartDetect.TabIndex = 5;
            this.btnStartDetect.Text = "Enable Detection";
            this.btnStartDetect.UseVisualStyleBackColor = true;
            this.btnStartDetect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // trackBarLaneY
            // 
            this.trackBarLaneY.Location = new System.Drawing.Point(17, 57);
            this.trackBarLaneY.Maximum = 0;
            this.trackBarLaneY.Name = "trackBarLaneY";
            this.trackBarLaneY.Size = new System.Drawing.Size(174, 45);
            this.trackBarLaneY.TabIndex = 0;
            // 
            // trackbarLaneWidth
            // 
            this.trackbarLaneWidth.Location = new System.Drawing.Point(17, 100);
            this.trackbarLaneWidth.Maximum = 0;
            this.trackbarLaneWidth.Name = "trackbarLaneWidth";
            this.trackbarLaneWidth.Size = new System.Drawing.Size(174, 45);
            this.trackbarLaneWidth.TabIndex = 2;
            // 
            // trackbarLaneHeight
            // 
            this.trackbarLaneHeight.Location = new System.Drawing.Point(18, 137);
            this.trackbarLaneHeight.Maximum = 0;
            this.trackbarLaneHeight.Name = "trackbarLaneHeight";
            this.trackbarLaneHeight.Size = new System.Drawing.Size(174, 45);
            this.trackbarLaneHeight.TabIndex = 3;
            // 
            // trackBarLaneX
            // 
            this.trackBarLaneX.Location = new System.Drawing.Point(16, 26);
            this.trackBarLaneX.Maximum = 0;
            this.trackBarLaneX.Name = "trackBarLaneX";
            this.trackBarLaneX.Size = new System.Drawing.Size(174, 45);
            this.trackBarLaneX.TabIndex = 1;
            // 
            // ibMonitor
            // 
            this.ibMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibMonitor.Location = new System.Drawing.Point(3, 3);
            this.ibMonitor.Name = "ibMonitor";
            this.ibMonitor.Size = new System.Drawing.Size(568, 531);
            this.ibMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibMonitor.TabIndex = 2;
            this.ibMonitor.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpenVideo,
            this.tsOpenCascade});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // tsOpenVideo
            // 
            this.tsOpenVideo.Name = "tsOpenVideo";
            this.tsOpenVideo.Size = new System.Drawing.Size(140, 22);
            this.tsOpenVideo.Text = "Video";
            // 
            // tsOpenCascade
            // 
            this.tsOpenCascade.Name = "tsOpenCascade";
            this.tsOpenCascade.Size = new System.Drawing.Size(140, 22);
            this.tsOpenCascade.Text = "Cascade xml";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ofdOpenFIle
            // 
            this.ofdOpenFIle.FileName = "Video File";
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLabel});
            this.Status.Location = new System.Drawing.Point(0, 539);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(784, 22);
            this.Status.TabIndex = 2;
            this.Status.Text = "statusStrip1";
            // 
            // statLabel
            // 
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // cbIncoming
            // 
            this.cbIncoming.AutoSize = true;
            this.cbIncoming.Location = new System.Drawing.Point(47, 178);
            this.cbIncoming.Name = "cbIncoming";
            this.cbIncoming.Size = new System.Drawing.Size(102, 17);
            this.cbIncoming.TabIndex = 7;
            this.cbIncoming.Text = "Incoming Traffic";
            this.cbIncoming.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.tblMainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMain";
            this.Text = "CarCounter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tblMainPanel.ResumeLayout(false);
            this.scSideBar.Panel1.ResumeLayout(false);
            this.scSideBar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSideBar)).EndInit();
            this.scSideBar.ResumeLayout(false);
            this.tblFilePanel.ResumeLayout(false);
            this.tblFilePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLaneY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarLaneWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarLaneHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLaneX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibMonitor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMainPanel;
        private System.Windows.Forms.SplitContainer scSideBar;
        private Emgu.CV.UI.ImageBox ibMonitor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdOpenFIle;
        private System.Windows.Forms.TableLayoutPanel tblFilePanel;
        private System.Windows.Forms.Button btnOpenVideo;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel statLabel;
        private System.Windows.Forms.Button btnOpenCascade;
        private System.Windows.Forms.Label lblCascade;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.ToolStripMenuItem tsOpenVideo;
        private System.Windows.Forms.ToolStripMenuItem tsOpenCascade;
        private System.Windows.Forms.TrackBar trackBarLaneX;
        private System.Windows.Forms.TrackBar trackBarLaneY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.TrackBar trackbarInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackbarLaneHeight;
        private System.Windows.Forms.TrackBar trackbarLaneWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartDetect;
        private System.Windows.Forms.CheckBox cbIncoming;
    }
}

