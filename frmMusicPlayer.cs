using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAFPCave
{
    public partial class frmMusicPlayer : Form
    {
        bool mouse_Click = false, control_Stop = false;

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        string s;

        public frmMusicPlayer()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            pnlSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if(pnlSubmenu.Visible == true)
            {
                pnlSubmenu.Visible = false;
            }
        }

        private void showSubmenu()
        {
            if(pnlSubmenu.Visible == false)
            {
                hideSubmenu();
                pnlSubmenu.Visible = true;
            }
            else
            {
                pnlSubmenu.Visible = false;
            }
        }
        
        //Mantener click sobre el header
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_Click = true;
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //Soltar el mouse del header
        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_Click = false;
        }

        //Al arrastrar el header
        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_Click == true)
            {
                this.Location = Cursor.Position;
            }
        }

        //Minimizar
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Maximizar
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        //Cerrar
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Btn Regresar
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 CaveLobby = new Form1();
            this.Hide();
            CaveLobby.Show();
        }

        //Mostrar Panel Submenu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            showSubmenu();
        }

        private Form activeForm = null;
        private void openChildform(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // ABRIR FORM REPRODUCIENDO
        private void btnPlaying_Click(object sender, EventArgs e)
        {
            openChildform(new frmReproduciendo());
        }

        private void runMP3()
        {
            player.URL = s;
            player.controls.play();
        }

        //STOP
        private void btnStop_Click(object sender, EventArgs e)
        {
            control_Stop = true;
            player.controls.pause();
        }

        //PLAY
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (control_Stop == true)
            {
                player.controls.play();
            }
            else
            {
                if (string.IsNullOrEmpty(DefaultSongs.fileSong))
                {
                    MessageBox.Show("Porfavor, importa una canción, o selecciona una en el apartado Canciones");
                }
                else
                {
                    player.URL = DefaultSongs.fileSong;
                    player.controls.play();
                }
            }
        }

        //IMPORT MUSIC
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if( dlg.ShowDialog() == DialogResult.OK)
            {
                s = dlg.FileName;
                Music_Data.cancion = 3;
                runMP3();
            }
        }

        //BARRA DE PROGRESO
        private void progressBarMusic_Click(object sender, EventArgs e)
        {

        }

        //TIMER
        private void timerMusic_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBarMusic.Maximum = (int)player.controls.currentItem.duration;
                progressBarMusic.Value = (int)player.controls.currentPosition;
            }
        }

        //VOLUMEN SONIDO
        private void trackVolumen_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackVolumen.Value;
        }

        //ABRIR FORM CANCIONES
        private void btnCanciones_Click(object sender, EventArgs e)
        {
            Music_Data.cancion = 6;
            openChildform(new frmCanciones());
        }
    }
}
