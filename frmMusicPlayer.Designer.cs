namespace WAFPCave
{
    partial class frmMusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusicPlayer));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.picVolumen = new System.Windows.Forms.PictureBox();
            this.trackVolumen = new System.Windows.Forms.TrackBar();
            this.progressBarMusic = new System.Windows.Forms.ProgressBar();
            this.WMPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlSubmenu = new System.Windows.Forms.Panel();
            this.btnCanciones = new System.Windows.Forms.Button();
            this.btnPlaying = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogoMusic = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.timerMusic = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.pnlSubmenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMusic)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.btnMaximize);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(250, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1083, 78);
            this.pnlHeader.TabIndex = 8;
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
            this.btnClose.Location = new System.Drawing.Point(1033, 22);
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
            this.btnMaximize.Location = new System.Drawing.Point(962, 12);
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
            this.btnMinimize.Location = new System.Drawing.Point(906, 21);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.Location = new System.Drawing.Point(1011, 7);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(60, 60);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(72, 7);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(60, 60);
            this.btnStop.TabIndex = 6;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(6, 7);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(60, 60);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.pnlControls.Controls.Add(this.picVolumen);
            this.pnlControls.Controls.Add(this.trackVolumen);
            this.pnlControls.Controls.Add(this.progressBarMusic);
            this.pnlControls.Controls.Add(this.btnUpload);
            this.pnlControls.Controls.Add(this.btnStop);
            this.pnlControls.Controls.Add(this.btnPlay);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.Location = new System.Drawing.Point(250, 796);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1083, 79);
            this.pnlControls.TabIndex = 7;
            // 
            // picVolumen
            // 
            this.picVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picVolumen.Image = ((System.Drawing.Image)(resources.GetObject("picVolumen.Image")));
            this.picVolumen.Location = new System.Drawing.Point(876, 0);
            this.picVolumen.Name = "picVolumen";
            this.picVolumen.Size = new System.Drawing.Size(61, 50);
            this.picVolumen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picVolumen.TabIndex = 13;
            this.picVolumen.TabStop = false;
            // 
            // trackVolumen
            // 
            this.trackVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackVolumen.Location = new System.Drawing.Point(811, 42);
            this.trackVolumen.Name = "trackVolumen";
            this.trackVolumen.Size = new System.Drawing.Size(182, 69);
            this.trackVolumen.TabIndex = 12;
            this.trackVolumen.Scroll += new System.EventHandler(this.trackVolumen_Scroll);
            // 
            // progressBarMusic
            // 
            this.progressBarMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarMusic.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBarMusic.Location = new System.Drawing.Point(150, 26);
            this.progressBarMusic.Name = "progressBarMusic";
            this.progressBarMusic.Size = new System.Drawing.Size(651, 14);
            this.progressBarMusic.TabIndex = 11;
            this.progressBarMusic.Click += new System.EventHandler(this.progressBarMusic_Click);
            // 
            // WMPlayer
            // 
            this.WMPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WMPlayer.Enabled = true;
            this.WMPlayer.Location = new System.Drawing.Point(145, 803);
            this.WMPlayer.Name = "WMPlayer";
            this.WMPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPlayer.OcxState")));
            this.WMPlayer.Size = new System.Drawing.Size(99, 60);
            this.WMPlayer.TabIndex = 10;
            this.WMPlayer.Visible = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(59, 148);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(120, 34);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Cave Music";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.LightGray;
            this.pnlSidebar.Controls.Add(this.pnlSubmenu);
            this.pnlSidebar.Controls.Add(this.WMPlayer);
            this.pnlSidebar.Controls.Add(this.btnMenu);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Controls.Add(this.btnRegresar);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 875);
            this.pnlSidebar.TabIndex = 6;
            // 
            // pnlSubmenu
            // 
            this.pnlSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlSubmenu.Controls.Add(this.btnCanciones);
            this.pnlSubmenu.Controls.Add(this.btnPlaying);
            this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenu.Location = new System.Drawing.Point(0, 250);
            this.pnlSubmenu.Name = "pnlSubmenu";
            this.pnlSubmenu.Size = new System.Drawing.Size(250, 100);
            this.pnlSubmenu.TabIndex = 8;
            // 
            // btnCanciones
            // 
            this.btnCanciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCanciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCanciones.FlatAppearance.BorderSize = 0;
            this.btnCanciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanciones.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanciones.ForeColor = System.Drawing.Color.White;
            this.btnCanciones.Location = new System.Drawing.Point(0, 50);
            this.btnCanciones.Name = "btnCanciones";
            this.btnCanciones.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCanciones.Size = new System.Drawing.Size(250, 50);
            this.btnCanciones.TabIndex = 4;
            this.btnCanciones.Text = "Canciones";
            this.btnCanciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCanciones.UseVisualStyleBackColor = false;
            this.btnCanciones.Click += new System.EventHandler(this.btnCanciones_Click);
            // 
            // btnPlaying
            // 
            this.btnPlaying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnPlaying.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaying.FlatAppearance.BorderSize = 0;
            this.btnPlaying.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaying.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaying.ForeColor = System.Drawing.Color.White;
            this.btnPlaying.Location = new System.Drawing.Point(0, 0);
            this.btnPlaying.Name = "btnPlaying";
            this.btnPlaying.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPlaying.Size = new System.Drawing.Size(250, 50);
            this.btnPlaying.TabIndex = 3;
            this.btnPlaying.Text = "Reproduciendo";
            this.btnPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaying.UseVisualStyleBackColor = false;
            this.btnPlaying.Click += new System.EventHandler(this.btnPlaying_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(0, 200);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(250, 50);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menú";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.picLogoMusic);
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 200);
            this.pnlLogo.TabIndex = 7;
            // 
            // picLogoMusic
            // 
            this.picLogoMusic.Image = ((System.Drawing.Image)(resources.GetObject("picLogoMusic.Image")));
            this.picLogoMusic.Location = new System.Drawing.Point(65, 22);
            this.picLogoMusic.Name = "picLogoMusic";
            this.picLogoMusic.Size = new System.Drawing.Size(111, 111);
            this.picLogoMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoMusic.TabIndex = 0;
            this.picLogoMusic.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(3, 812);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(60, 60);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.DarkGray;
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.picTitle);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 78);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1083, 718);
            this.pnlContent.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(479, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cave Music";
            // 
            // picTitle
            // 
            this.picTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(370, 122);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(372, 345);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // timerMusic
            // 
            this.timerMusic.Enabled = true;
            this.timerMusic.Tick += new System.EventHandler(this.timerMusic_Tick);
            // 
            // frmMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 875);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusicPlayer";
            this.Text = "frmMusicPlayer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSubmenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMusic)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.PictureBox picLogoMusic;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlSubmenu;
        private System.Windows.Forms.Button btnCanciones;
        private System.Windows.Forms.Button btnPlaying;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picTitle;
        private AxWMPLib.AxWindowsMediaPlayer WMPlayer;
        private System.Windows.Forms.ProgressBar progressBarMusic;
        private System.Windows.Forms.Timer timerMusic;
        private System.Windows.Forms.PictureBox picVolumen;
        private System.Windows.Forms.TrackBar trackVolumen;
    }
}