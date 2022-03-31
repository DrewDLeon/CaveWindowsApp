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
    public partial class frmCanciones : Form
    {
        public frmCanciones()
        {
            InitializeComponent();
        }
        
        //Cancion 1
        private void btnSong1_Click(object sender, EventArgs e)
        {
            Music_Data.cancion = 0;
            DefaultSongs.fileSong = "kidCudi.mp3";
        }

        //cancion 2
        private void btnSong2_Click(object sender, EventArgs e)
        {
            Music_Data.cancion = 1;
            DefaultSongs.fileSong = "duaLipa.mp3";
        }

        //CERRAR FORM
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Cancion 3
        private void btnSong3_Click(object sender, EventArgs e)
        {
            Music_Data.cancion = 2;
            DefaultSongs.fileSong = "eminem.mp3";
        }

        //Cancion 4
        private void btnSong4_Click(object sender, EventArgs e)
        {
            Music_Data.cancion = 3;
            DefaultSongs.fileSong = "calvinHarris.mp3";
        }

        //Cancion 5
        private void btnSong5_Click(object sender, EventArgs e)
        {
            Music_Data.cancion = 4;
            DefaultSongs.fileSong = "shrek.mp3";
        }

        private void btnSong6_Click(object sender, EventArgs e)
        {
            Music_Data.cancion = 5;
            DefaultSongs.fileSong = "coldplay.mp3";
        }
    }
}
