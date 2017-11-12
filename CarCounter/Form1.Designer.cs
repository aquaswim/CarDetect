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
            this.ibMonitor = new Emgu.CV.UI.ImageBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdOpenFIle = new System.Windows.Forms.OpenFileDialog();
            this.tblFilePanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.statLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOpenCascade = new System.Windows.Forms.Button();
            this.lblVideo = new System.Windows.Forms.Label();
            this.lblCascade = new System.Windows.Forms.Label();
            this.tsOpenVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOpenCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tblMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSideBar)).BeginInit();
            this.scSideBar.Panel1.SuspendLayout();
            this.scSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibMonitor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tblFilePanel.SuspendLayout();
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
            this.tblMainPanel.Size = new System.Drawing.Size(584, 337);
            this.tblMainPanel.TabIndex = 0;
            // 
            // scSideBar
            // 
            this.scSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSideBar.Location = new System.Drawing.Point(377, 3);
            this.scSideBar.Name = "scSideBar";
            this.scSideBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scSideBar.Panel1
            // 
            this.scSideBar.Panel1.Controls.Add(this.tblFilePanel);
            this.scSideBar.Size = new System.Drawing.Size(204, 331);
            this.scSideBar.SplitterDistance = 130;
            this.scSideBar.TabIndex = 0;
            // 
            // ibMonitor
            // 
            this.ibMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibMonitor.Location = new System.Drawing.Point(3, 3);
            this.ibMonitor.Name = "ibMonitor";
            this.ibMonitor.Size = new System.Drawing.Size(368, 331);
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
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
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
            // tblFilePanel
            // 
            this.tblFilePanel.ColumnCount = 2;
            this.tblFilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tblFilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFilePanel.Controls.Add(this.lblCascade, 1, 1);
            this.tblFilePanel.Controls.Add(this.btnOpenCascade, 0, 1);
            this.tblFilePanel.Controls.Add(this.btnOpenVideo, 0, 0);
            this.tblFilePanel.Controls.Add(this.lblVideo, 1, 0);
            this.tblFilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilePanel.Location = new System.Drawing.Point(0, 0);
            this.tblFilePanel.Name = "tblFilePanel";
            this.tblFilePanel.RowCount = 2;
            this.tblFilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilePanel.Size = new System.Drawing.Size(202, 128);
            this.tblFilePanel.TabIndex = 0;
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenVideo.Location = new System.Drawing.Point(3, 10);
            this.btnOpenVideo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(62, 44);
            this.btnOpenVideo.TabIndex = 0;
            this.btnOpenVideo.Text = "Open Video";
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLabel});
            this.Status.Location = new System.Drawing.Point(0, 339);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(584, 22);
            this.Status.TabIndex = 2;
            this.Status.Text = "statusStrip1";
            // 
            // statLabel
            // 
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // btnOpenCascade
            // 
            this.btnOpenCascade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenCascade.Location = new System.Drawing.Point(3, 74);
            this.btnOpenCascade.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnOpenCascade.Name = "btnOpenCascade";
            this.btnOpenCascade.Size = new System.Drawing.Size(62, 44);
            this.btnOpenCascade.TabIndex = 1;
            this.btnOpenCascade.Text = "Open Cascade";
            this.btnOpenCascade.UseVisualStyleBackColor = true;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVideo.Location = new System.Drawing.Point(71, 0);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(128, 64);
            this.lblVideo.TabIndex = 2;
            this.lblVideo.Text = "label1";
            this.lblVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCascade
            // 
            this.lblCascade.AutoSize = true;
            this.lblCascade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCascade.Location = new System.Drawing.Point(71, 64);
            this.lblCascade.Name = "lblCascade";
            this.lblCascade.Size = new System.Drawing.Size(128, 64);
            this.lblCascade.TabIndex = 3;
            this.lblCascade.Text = "label1";
            this.lblCascade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsOpenVideo
            // 
            this.tsOpenVideo.Name = "tsOpenVideo";
            this.tsOpenVideo.Size = new System.Drawing.Size(152, 22);
            this.tsOpenVideo.Text = "Video";
            // 
            // tsOpenCascade
            // 
            this.tsOpenCascade.Name = "tsOpenCascade";
            this.tsOpenCascade.Size = new System.Drawing.Size(152, 22);
            this.tsOpenCascade.Text = "Cascade xml";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.tblMainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmMain";
            this.Text = "CarCounter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tblMainPanel.ResumeLayout(false);
            this.scSideBar.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSideBar)).EndInit();
            this.scSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibMonitor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tblFilePanel.ResumeLayout(false);
            this.tblFilePanel.PerformLayout();
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
    }
}

