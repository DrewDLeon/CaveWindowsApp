namespace WAFPCave
{
    partial class frmCaveLearn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaveLearn));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.picLogoMusic = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.picDatos = new System.Windows.Forms.PictureBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnFotografia = new System.Windows.Forms.Button();
            this.btnCine = new System.Windows.Forms.Button();
            this.btnMusica = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMusic)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDatos)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.LightGray;
            this.pnlSidebar.Controls.Add(this.btnRegresar);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.picLogoMusic);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(246, 831);
            this.pnlSidebar.TabIndex = 7;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(3, 768);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(60, 60);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(58, 161);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(119, 34);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Cave Learn";
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
            this.pnlHeader.Size = new System.Drawing.Size(1119, 78);
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
            this.btnClose.Location = new System.Drawing.Point(1069, 22);
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
            this.btnMaximize.Location = new System.Drawing.Point(998, 12);
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
            this.btnMinimize.Location = new System.Drawing.Point(942, 21);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnlContent.Controls.Add(this.picDatos);
            this.pnlContent.Controls.Add(this.lblSubtitle);
            this.pnlContent.Controls.Add(this.lblInfo);
            this.pnlContent.Controls.Add(this.lblTitle);
            this.pnlContent.Controls.Add(this.pnlBotones);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(246, 78);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1119, 753);
            this.pnlContent.TabIndex = 10;
            // 
            // picDatos
            // 
            this.picDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picDatos.Location = new System.Drawing.Point(8, 400);
            this.picDatos.Name = "picDatos";
            this.picDatos.Size = new System.Drawing.Size(480, 341);
            this.picDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDatos.TabIndex = 17;
            this.picDatos.TabStop = false;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtitle.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 68);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Padding = new System.Windows.Forms.Padding(40, 20, 0, 0);
            this.lblSubtitle.Size = new System.Drawing.Size(868, 62);
            this.lblSubtitle.TabIndex = 16;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(0, 147);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.lblInfo.Size = new System.Drawing.Size(868, 302);
            this.lblInfo.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(30, 20, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(237, 68);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Sabías qué?";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlBotones.Controls.Add(this.btnFotografia);
            this.pnlBotones.Controls.Add(this.btnCine);
            this.pnlBotones.Controls.Add(this.btnMusica);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotones.Location = new System.Drawing.Point(868, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(251, 753);
            this.pnlBotones.TabIndex = 13;
            // 
            // btnFotografia
            // 
            this.btnFotografia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFotografia.FlatAppearance.BorderSize = 0;
            this.btnFotografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotografia.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFotografia.ForeColor = System.Drawing.Color.White;
            this.btnFotografia.Location = new System.Drawing.Point(3, 229);
            this.btnFotografia.Name = "btnFotografia";
            this.btnFotografia.Size = new System.Drawing.Size(251, 220);
            this.btnFotografia.TabIndex = 14;
            this.btnFotografia.Text = "Fotografia";
            this.btnFotografia.UseVisualStyleBackColor = true;
            this.btnFotografia.Click += new System.EventHandler(this.btnFotografia_Click);
            // 
            // btnCine
            // 
            this.btnCine.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCine.FlatAppearance.BorderSize = 0;
            this.btnCine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCine.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCine.ForeColor = System.Drawing.Color.White;
            this.btnCine.Location = new System.Drawing.Point(0, 455);
            this.btnCine.Name = "btnCine";
            this.btnCine.Size = new System.Drawing.Size(251, 220);
            this.btnCine.TabIndex = 13;
            this.btnCine.Text = "Cine";
            this.btnCine.UseVisualStyleBackColor = true;
            this.btnCine.Click += new System.EventHandler(this.btnCine_Click);
            // 
            // btnMusica
            // 
            this.btnMusica.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMusica.FlatAppearance.BorderSize = 0;
            this.btnMusica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusica.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusica.ForeColor = System.Drawing.Color.White;
            this.btnMusica.Location = new System.Drawing.Point(0, 3);
            this.btnMusica.Name = "btnMusica";
            this.btnMusica.Size = new System.Drawing.Size(251, 220);
            this.btnMusica.TabIndex = 12;
            this.btnMusica.Text = "Musica";
            this.btnMusica.UseVisualStyleBackColor = true;
            this.btnMusica.Click += new System.EventHandler(this.btnMusica_Click);
            // 
            // frmCaveLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 831);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaveLearn";
            this.Text = "frmCaveLearn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMusic)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDatos)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox picLogoMusic;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnMusica;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnCine;
        private System.Windows.Forms.Button btnFotografia;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox picDatos;
    }
}