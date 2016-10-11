using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Que_fait_le_Roi
{
    public partial class QueFaitLeRoi : Form
    {
        public QueFaitLeRoi()
        {
            InitializeComponent();
        }
    }

    public partial class QueFaitLeRoi4Panel : Panel
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel conteneurCarte;
        private System.Windows.Forms.Panel conteneurBouton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel conteneurCarteAPlacer;
        private System.Windows.Forms.PictureBox pictureBox4;

        Random localisationBouton = new Random();
        Random localisationCarte = new Random();
        Random localisationCarteAPlacer = new Random();
        List<Point> coordonneesCarte = new List<Point>(); 
        List<Point> coordonneesBouton = new List<Point>();
        List<Point> coordonneesCarteAPlacer = new List<Point>();

        Image imageRecuperee;
        String sonTag;
        String carteTag;
        String receveurTag;
        Boolean sonBoutonEcoute;

        public QueFaitLeRoi4Panel()
        {
            initialize();
            QueFaitLeRoi_Load();
        }

        private void QueFaitLeRoi_Load()
        {
            this.Enabled = true;
            Score.Text = "0";
            carteTag = "";
            sonTag = "";
            receveurTag = "";
            sonBoutonEcoute = false;
            imageRecuperee = null;

            button1.Tag = "1";
            button1.Text = "Le roi rentre au château.";
            button2.Tag = "2";
            button2.Text = "Kral okula girer.";
            button3.Tag = "3";
            button3.Text = "Le roi traverse la forêt.";
            button4.Tag = "4";
            button4.Text = "Kral bahceyi gecer.";

            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.BorderStyle = BorderStyle.FixedSingle;
                image.AllowDrop = false;
                image.Image = null;
                image.Enabled = true;
                coordonneesCarteAPlacer.Add(image.Location); 
            }

            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                int next = localisationCarteAPlacer.Next(coordonneesCarteAPlacer.Count);
                Point p = coordonneesCarteAPlacer[next];
                image.Location = p;
                coordonneesCarteAPlacer.Remove(p);
            }

            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Visible = true;
                image.Enabled = true;
                coordonneesCarte.Add(image.Location); 
            }

            foreach (PictureBox image in conteneurCarte.Controls)
            {
                int next = localisationCarte.Next(coordonneesCarte.Count);
                Point p = coordonneesCarte[next];
                image.Location = p;
                coordonneesCarte.Remove(p);
            }

            foreach (Button bouton in conteneurBouton.Controls)
            {
                bouton.Enabled = true;
                coordonneesBouton.Add(bouton.Location);
            }

            foreach (Button bouton in conteneurBouton.Controls)
            {
                int next = localisationBouton.Next(coordonneesBouton.Count);
                Point p = coordonneesBouton[next];
                bouton.Location = p;
                coordonneesBouton.Remove(p);
            }
        }

        private void Ecouter(object sender, EventArgs e)
        {
            Button bouton = (Button)sender;
            sonTag = (String)bouton.Tag;
            sonBoutonEcoute = true;

            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.AllowDrop = true;
            }

            if ((String)bouton.Tag == "1")
            {
                System.IO.Stream leRoiRentreAuChateauSon = Properties.Resources.leRoiRentreAuChateauSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(leRoiRentreAuChateauSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "2")
            {
                System.IO.Stream kralOkulaGirerSon = Properties.Resources.kralOkulaGirerSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(kralOkulaGirerSon);
                son.Play();

            }
            else if ((String)bouton.Tag == "3")
            {
                System.IO.Stream leRoiTraverseLaForetSon = Properties.Resources.leRoiTraverseLaForetSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(leRoiTraverseLaForetSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "4")
            {
                System.IO.Stream kralBahceyiGecerSon = Properties.Resources.kralBahceyiGecerSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(kralBahceyiGecerSon);
                son.Play();
            }
        }

        private void Image_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Image_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            receveurTag = (String)image.Tag;

            if (carteTag == sonTag & receveurTag == sonTag)
            {
                image.Image = imageRecuperee;
                Score.Text = Convert.ToString(Convert.ToInt32(Score.Text) + 1);
                sonBoutonEcoute = false;

                System.IO.Stream applaudissement = Properties.Resources.applaudissement;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(applaudissement);
                son.Play();
                MessageBox.Show("Bien joué !", "Bravo !!");

                if (sonTag == "1")
                {
                    pictureBox1.Hide();
                    image.Enabled = false;
                }
                else if (sonTag == "2")
                {
                    pictureBox2.Hide();
                    image.Enabled = false;
                }
                else if (sonTag == "3")
                {
                    pictureBox3.Hide();
                    image.Enabled = false;
                }
                else if (sonTag == "4")
                {
                    pictureBox4.Hide();
                    image.Enabled = false;
                }
            }
            else
            {
                System.IO.Stream pouet = Properties.Resources.pouet;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(pouet);
                son.Play();

                MessageBox.Show("Ré-essayez !", "Dommage !");

                image.Image = null;
            }

            if (Score.Text == "4")
            {
                foreach (PictureBox imageCarte in conteneurCarte.Controls)
                {
                    imageCarte.Enabled = false;
                }

                foreach (Button bouton in conteneurBouton.Controls)
                {
                    bouton.Enabled = false;
                }
                
                MessageBox.Show("Tu as fini le 1er niveau !", "Bravo !");
                QueFaitLeRoi_Load();
                this.Enabled = false;
            }
        }

        private void receveurImage_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            imageRecuperee = image.Image;
            carteTag = (String)image.Tag;

            if (sonBoutonEcoute == true & (String)image.Tag == "1")
            {
                System.IO.Stream chateauSon = Properties.Resources.chateauSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(chateauSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "2")
            {
                System.IO.Stream okulSon = Properties.Resources.okulSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(okulSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "3")
            {
                System.IO.Stream foretSon = Properties.Resources.foretSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(foretSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "4")
            {
                System.IO.Stream bahceSon = Properties.Resources.bahceSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(bahceSon);
                son.Play();
            }

            conteneurCarteAPlacer.DoDragDrop("x", DragDropEffects.All);
        }
    }
}
