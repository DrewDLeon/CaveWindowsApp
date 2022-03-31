namespace WAFPCave
{
    partial class frmCaveMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaveMovies));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblTracklist = new System.Windows.Forms.Label();
            this.lstTrack = new System.Windows.Forms.ListBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.picLogoMusic = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblTrackFinal = new System.Windows.Forms.Label();
            this.lblTrackStart = new System.Windows.Forms.Label();
            this.progressBarMovies = new System.Windows.Forms.ProgressBar();
            this.btnEnlarge = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.timerMovies = new System.Windows.Forms.Timer(this.components);
            this.picVolumen = new System.Windows.Forms.PictureBox();
            this.trackVolumen = new System.Windows.Forms.TrackBar();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMusic)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolumen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.LightGray;
            this.pnlSidebar.Controls.Add(this.lblTracklist);
            this.pnlSidebar.Controls.Add(this.lstTrack);
            this.pnlSidebar.Controls.Add(this.btnRegresar);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.picLogoMusic);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(246, 871);
            this.pnlSidebar.TabIndex = 7;
            // 
            // lblTracklist
            // 
            this.lblTracklist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTracklist.AutoSize = true;
            this.lblTracklist.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTracklist.Location = new System.Drawing.Point(58, 402);
            this.lblTracklist.Name = "lblTracklist";
            this.lblTracklist.Size = new System.Drawing.Size(105, 34);
            this.lblTracklist.TabIndex = 8;
            this.lblTracklist.Text = "Track List";
            // 
            // lstTrack
            // 
            this.lstTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTrack.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTrack.FormattingEnabled = true;
            this.lstTrack.HorizontalScrollbar = true;
            this.lstTrack.ItemHeight = 29;
            this.lstTrack.Location = new System.Drawing.Point(3, 439);
            this.lstTrack.Name = "lstTrack";
            this.lstTrack.Size = new System.Drawing.Size(240, 352);
            this.lstTrack.TabIndex = 7;
            this.lstTrack.SelectedIndexChanged += new System.EventHandler(this.lstTrack_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(3, 808);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(60, 60);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(58, 161);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(130, 34);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Cave Movies";
            // 
            // picLogoMusic
            // 
            this.picLogoMusic.Image = ((System.Drawing.Image)(resources.GetObject("picLogoMusic.Image")));
            this.picLogoMusic.Location = new System.Drawing.Point(64, 35);
            this.picLogoMusic.Name = "picLogoMusic";
            this.picLogoMusic.Size = new System.Drawing.Size(111, 111);
            this.picLogoMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoMusic.TabIndex = 0;
            this.picLogoMusic.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.btnMaximize);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(246, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1110, 78);
            this.pnlHeader.TabIndex = 9;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1063, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(992, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(47, 57);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(936, 21);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.pnlControls.Controls.Add(this.picVolumen);
            this.pnlControls.Controls.Add(this.trackVolumen);
            this.pnlControls.Controls.Add(this.btnNext);
            this.pnlControls.Controls.Add(this.btnBack);
            this.pnlControls.Controls.Add(this.lblTrackFinal);
            this.pnlControls.Controls.Add(this.lblTrackStart);
            this.pnlControls.Controls.Add(this.progressBarMovies);
            this.pnlControls.Controls.Add(this.btnEnlarge);
            this.pnlControls.Controls.Add(this.btnUpload);
            this.pnlControls.Controls.Add(this.btnStop);
            this.pnlControls.Controls.Add(this.btnPlay);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.Location = new System.Drawing.Point(246, 748);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1110, 123);
            this.pnlControls.TabIndex = 10;
            // 
            // lblTrackFinal
            // 
            this.lblTrackFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrackFinal.AutoSize = true;
            this.lblTrackFinal.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackFinal.ForeColor = System.Drawing.Color.White;
            this.lblTrackFinal.Location = new System.Drawing.Point(888, 6);
            this.lblTrackFinal.Name = "lblTrackFinal";
            this.lblTrackFinal.Size = new System.Drawing.Size(55, 29);
            this.lblTrackFinal.TabIndex = 14;
            this.lblTrackFinal.Text = "00:00";
            // 
            // lblTrackStart
            // 
            this.lblTrackStart.AutoSize = true;
            this.lblTrackStart.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackStart.ForeColor = System.Drawing.Color.White;
            this.lblTrackStart.Location = new System.Drawing.Point(170, 6);
            this.lblTrackStart.Name = "lblTrackStart";
            this.lblTrackStart.Size = new System.Drawing.Size(55, 29);
            this.lblTrackStart.TabIndex = 13;
            this.lblTrackStart.Text = "00:00";
            // 
            // progressBarMovies
            // 
            this.progressBarMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarMovies.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBarMovies.Location = new System.Drawing.Point(231, 16);
            this.progressBarMovies.Name = "progressBarMovies";
            this.progressBarMovies.Size = new System.Drawing.Size(651, 10);
            this.progressBarMovies.TabIndex = 12;
            // 
            // btnEnlarge
            // 
            this.btnEnlarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnlarge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEnlarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnlarge.Image = ((System.Drawing.Image)(resources.GetObject("btnEnlarge.Image")));
            this.btnEnlarge.Location = new System.Drawing.Point(981, 60);
            this.btnEnlarge.Name = "btnEnlarge";
            this.btnEnlarge.Size = new System.Drawing.Size(60, 60);
            this.btnEnlarge.TabIndex = 9;
            this.btnEnlarge.UseVisualStyleBackColor = true;
            this.btnEnlarge.Click += new System.EventHandler(this.btnEnlarge_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.Location = new System.Drawing.Point(1047, 60);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(60, 60);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(138, 60);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(60, 60);
            this.btnStop.TabIndex = 6;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(72, 60);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(60, 60);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnlContent.Controls.Add(this.player);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(246, 78);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1110, 670);
            this.pnlContent.TabIndex = 12;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Padding = new System.Windows.Forms.Padding(10);
            this.player.Size = new System.Drawing.Size(1110, 670);
            this.player.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(6, 60);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 60);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(204, 60);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 60);
            this.btnNext.TabIndex = 16;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timerMovies
            // 
            this.timerMovies.Tick += new System.EventHandler(this.timerMovies_Tick);
            // 
            // picVolumen
            // 
            this.picVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picVolumen.Image = ((System.Drawing.Image)(resources.GetObject("picVolumen.Image")));
            this.picVolumen.Location = new System.Drawing.Point(726, 61);
            this.picVolumen.Name = "picVolumen";
            this.picVolumen.Size = new System.Drawing.Size(61, 50);
            this.picVolumen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picVolumen.TabIndex = 18;
            this.picVolumen.TabStop = false;
            // 
            // trackVolumen
            // 
            this.trackVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackVolumen.Location = new System.Drawing.Point(793, 70);
            this.trackVolumen.Name = "trackVolumen";
            this.trackVolumen.Size = new System.Drawing.Size(182, 69);
            this.trackVolumen.TabIndex = 17;
            this.trackVolumen.Scroll += new System.EventHandler(this.trackVolumen_Scroll);
            // 
            // frmCaveMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 871);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaveMovies";
            this.Text = "frmCaveMovies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMusic)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolumen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox picLogoMusic;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnEnlarge;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ProgressBar progressBarMovies;
        private System.Windows.Forms.Label lblTrackFinal;
        private System.Windows.Forms.Label lblTrackStart;
        private System.Windows.Forms.Label lblTracklist;
        private System.Windows.Forms.ListBox lstTrack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer timerMovies;
        private System.Windows.Forms.PictureBox picVolumen;
        private System.Windows.Forms.TrackBar trackVolumen;
    }
}