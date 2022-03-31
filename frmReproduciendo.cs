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
    public partial class frmReproduciendo : Form
    {

        string[] music_Name = { "Day n' Nite", "New Rules", "Till I Collapse","Summer", "Hallelujah", "Viva la Vida", "Cancion Desconocida" };
        string[] music_Autor = { "Kid Cudi", "Dua Lipa", "Eminem", "Calvin Harris","Rufus Wainwright","Coldplay", "Autor Desconocido" };
        string[] music_Genre = {"House", "Pop", "Rap","Electro","Orquestal","Indie", "Genero Desconocido"};

        public frmReproduciendo()
        {
            InitializeComponent();
        }

        private void picClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        //EDITAR LABEL FORM 
        private void frmReproduciendo_Load(object sender, EventArgs e)
        {
            lblAutor.Text = music_Autor[Music_Data.cancion];
            lblTitle.Text = music_Name[Music_Data.cancion];
            lblGenero.Text = music_Genre[Music_Data.cancion];
            lblPlaying.Text = "Now Playing: "+ music_Autor[Music_Data.cancion] + " - " + music_Name[Music_Data.cancion];
        }
    }
}
