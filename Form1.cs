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
    public partial class Form1 : Form
    {
        bool mouse_Click = false;

        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        //Cuztomize Design
        private void customizeDesign()
        {
            pnlRedes.Visible = false;
        }

        //Esconder Submenu Redes
        private void hideSubmenu()
        {
            if(pnlRedes.Visible == true)
            {
                pnlRedes.Visible = false;
            }
        }

        //Mostrar Submenu Redes
        private void showSubmenu()
        {
            if(pnlRedes.Visible == false)
            {
                hideSubmenu();
                pnlRedes.Visible = true;
            }
            else
            {
                pnlRedes.Visible = false;
            }
        }

        //Al mantener click sobre el header
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_Click = true;
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //Btn Salir
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Btn Minimizar
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Al soltar el mouse del header
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

        //Click sobre panel Music
        private void pnlMusic_MouseClick(object sender, MouseEventArgs e)
        {
            frmMusicPlayer CaveMusic = new frmMusicPlayer();
            this.Hide();
            CaveMusic.Show();
        }

        //Double Click sobre panel Music
        private void pnlMusic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmMusicPlayer CaveMusic = new frmMusicPlayer();
            this.Hide();
            CaveMusic.Show();
        }

        //Click sobre panel Learn
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            frmCaveLearn CaveLearn = new frmCaveLearn();
            this.Hide();
            CaveLearn.Show();
        }

        //Double Click sobre panel Learn
        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmCaveLearn CaveLearn = new frmCaveLearn();
            this.Hide();
            CaveLearn.Show();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            frmCaveMovies CaveMovies = new frmCaveMovies();
            this.Hide();
            CaveMovies.Show();
        }

        //Mouse Hover Panel Music
        private void pnlMusic_MouseHover(object sender, EventArgs e)
        {
            pnlMusic.BackColor = Color.FromArgb(222, 82, 66);
        }

        //Mouse Hover sobre Panel Learn
        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(222, 82, 66);
        }

        //Mouse Leaves Hover from Pnl Music
        private void pnlMusic_MouseLeave(object sender, EventArgs e)
        {
            pnlMusic.BackColor = Color.FromArgb(190, 63, 63);
        }

        //Mouse Leaves Hover from Pnl Learn
        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(190, 63, 63);
        }

        //Mouse Leaves Hover From Pnl Movies
        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(190, 63, 63);
        }

        //Mouse Hover sobre Panel Movies
        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(222, 82, 66);
        }

        //BOTON INFO
        private void btnInfo_Click(object sender, EventArgs e)
        {
            showSubmenu();
        }

//REDES SOCIALES
        //BOTON INSTAGRAM
        private void btnInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/cavedevs/");
        }
        //BOTON FACEBOOK
        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Cave-Inc-110831911580605");
        }
        //BOTON TWITTAH
        private void btnTwitter_Click(object sender, EventArgs e)
        {
            lblProximamente.Visible = true;
        }
    }
}
