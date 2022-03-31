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
    public partial class frmCaveLearn : Form
    {
        bool mouse_Click = false;

        //MUSICA 5 DATOS CURIOSOS
        string[] musica_Subtitle = {
            "La música influye en la presión arterial.",
            "La música aumenta la resistencia física de las personas",
            "La música se instala en la mente",
            "El disco más vendido de la historia.",
            "La música alta da sed"
        };
        string[] musica_Info = {
            "El efecto de la música en las pulsaciones cardíacas se nota. Dependiendo del tipo de música el corazón se acelera o se relaja. Y es que el corazón adapta sus latidos a la música que estás escuchando.",
            "Hacer ejercicio escuchando música es fundamental, no falta la música en ningún gimnasio. La resistencia física de las personas puede llegar a aumentar incluso un 15% si están emitiendo música rock o pop, o con ritmo.",
            "Existe un fenómeno llamado gusano musical, que tiene lugar cuando una melodía o una canción se nos repite una y otra vez en la cabeza.",
            "El sexto álbum de Michael Jackson “Thriller” es el más vendido en la historia de la música, con unas ventas aproximadas de entre 51 a 65 millones de copias desde su lanzamiento en 1982.",
            "Ahora entenderás el porqué de escuchar música a todo volumen en las discotecas y lugares de ocio. Así es, cuando la música está muy alta, el cuerpo reacciona necesitando beber líquido mucho más rápido de lo habitual."
            };
        string[] musica_Fotos ={
            "presion.jpg",
            "resistencia.jpg",
            "musicaMente.jpg",
            "musicaThriller.jpg",
            "musicaSed.jpg"
        };

        //CINE 5 DATOS CURIOSOS
        string[] cine_Subtitle = {
            "¿Por qué el cine es el séptimo arte?",
            "¿Quién inventó la claqueta?",
            "Juegos del Hambre",
            "El Respaldo Pixar",
            "Sonidos Jurasicos"};
        string[] cine_Info = {
            "Fue el artista italiano Ricciotto Canuto quien con su Manifiesto de las siete artes estableció la jerarquía moderna que ahora todos utilizamos: arquitectura, escultura, pintura, música, poesía/literatura, danza y cine.",
            "El creador de la chaqueta fue el cineasta australiano Frank W. Thring, quien buscaba algo más funcional que las pizarras que se utilizaban hasta entonces. Al añadirle un listón con bisagra a la pizarra, permitió que el sonido acompañase a la información que escribían en ella, indicando el momento exacto en que arrancaba la grabación.",
            "En Los Juegos del Hambre Jennifer Lawrence se quedó sorda durante el rodaje de la película, al bucear, un chorro de agua le perforó el tímpano.",
            "Una de las películas que no saldría a la gran pantalla era Toy Story 2, se planteó como un vídeo de Pixar pero gustó tanto que decidieron proyectarla en cine.",
            "En Jurassic Park el sonido que emitía el Rex se hizo mezclando sonidos de caimán. tigre y una cría de elefante."};
        string[] cine_Fotos = {
            "cineSeptimoArte.png",
            "claqueta.jpg",
            "juegosdelhambre.jpg",
            "toystory2.jpg",
            "jurassicpark.jpg"
        };

        //FOTOGRAFIA 4 DATOS CURIOSOS
        string[] foto_Subtitle = {
            "Ver la fotografía de la persona amada reduce el dolor.",
            "La primera fotografía submarina fue tomada en el año 1890",
            "¿Sabías que existió la cámara de fotos más grande del mundo?",
            "Una de las fotos más vistas del mundo, es el fondo de Windows XP"
        };
        string[] foto_Info = {
            "Explorando el cerebro de 15 voluntarios con ayuda de resonancia magnética, Arthur Aron, profesor de psicología en la Universidad de New York, ha demostrado que las áreas del cerebro activadas al ver la foto de tu pareja pueden reducir el dolor hasta en un 44%, tal como lo hace el paracetamol.",
            "En el año 1890 se obtuvo la primera fotografía submarina. Fue tomada por William Louis Boutan y muestra a un buzo bajo el mar.",
            "La mamut, denominada la cámara más grande del mundo, y estuvo a inicios del siglo XX. Su peso era de 634 kg y sus placas tenían medidas de 150x240cm.",
            "Una de las fotos más vistas del mundo es un paisaje retratado realmente en el norte de California, pues era el fondo de pantalla por defecto de Windows XP, lo que hizo que millones de personas la conocieran."
        };
        string[] foto_Fotos = {
            "fotoAmor.jpg",
            "fotoSubmarina.jpeg",
            "camaraMamut.jpg",
            "windowsxp.jpg"
        };

        public frmCaveLearn()
        {
            InitializeComponent();
        }

        //Mantener el click en header
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_Click = true;
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //Soltar el click de header
        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_Click = false;
        }

        //Arrastrar el header
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

        //Cerrar Aplicacion
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

        //Boton Musica
        private void btnMusica_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 5);
            lblSubtitle.Text = musica_Subtitle[random];
            lblInfo.Text = musica_Info[random];
            picDatos.Image = Image.FromFile(musica_Fotos[random]);
        }

        //Boton Fotografia
        private void btnFotografia_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 4);
            lblSubtitle.Text = foto_Subtitle[random];
            lblInfo.Text = foto_Info[random];
            picDatos.Image = Image.FromFile(foto_Fotos[random]);
        }

        //Boton Cine
        private void btnCine_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 5);
            lblSubtitle.Text = cine_Subtitle[random];
            lblInfo.Text = cine_Info[random];
            picDatos.Image = Image.FromFile(cine_Fotos[random]);
        }
    }
}
