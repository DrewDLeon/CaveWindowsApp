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
    public partial class frmCaveMovies : Form
    {
        bool mouse_Click = false;
        string[] paths, files;
        

        public frmCaveMovies()
        {
            InitializeComponent();
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
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        //Boton Cerrar
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

        //Boton Agrandar
        private void btnEnlarge_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        //INDEX CHANGE LISTBOX
        private void lstTrack_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[lstTrack.SelectedIndex];
            player.Ctlcontrols.play();
            timerMovies.Start();
        }

        //BOTON STOP
        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        //BOTON NEXT
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(lstTrack.SelectedIndex < lstTrack.Items.Count - 1)
            {
                lstTrack.SelectedIndex = lstTrack.SelectedIndex + 1;
            }
            else
            {
                lstTrack.SelectedIndex = 0;
            }
        }

        //BOTON PREVIO VIDEO
        private void btnBack_Click(object sender, EventArgs e)
        {
            if(lstTrack.SelectedIndex > 0)
            {
                lstTrack.SelectedIndex = lstTrack.SelectedIndex - 1;
            }
        }

        //TIMER
        private void timerMovies_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBarMovies.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBarMovies.Value = (int)player.Ctlcontrols.currentPosition;
            }
            lblTrackStart.Text = player.Ctlcontrols.currentPositionString;
            lblTrackFinal.Text = player.Ctlcontrols.currentItem.durationString.ToString();
        }

        //VOLUMEN DE SONIDO
        private void trackVolumen_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackVolumen.Value;
        }

        //BOTON PLAY
        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        //IMPORT FILES
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = dlg.SafeFileNames;
                paths = dlg.FileNames;
                for(int i = 0; i < files.Length; i++)
                {
                    lstTrack.Items.Add(files[i]);
                }
            }
        }
    }
}
