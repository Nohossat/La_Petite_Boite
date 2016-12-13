using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using Ressources;
using System.IO;

namespace La_petite_boite
{
    public partial class tutoQueFaitLeRoi : Form
    {
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Panel conteneurCarte;
        private Panel conteneurBouton;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Panel conteneurCarteAPlacer;

        Random localisationBouton = new Random();
        Random localisationCarte = new Random();
        Random localisationCarteAPlacer = new Random();
        List<Point> coordonneesCarte = new List<Point>();
        List<Point> coordonneesBouton = new List<Point>();
        List<Point> coordonneesCarteAPlacer = new List<Point>();
        List<Stream> audio = new List<Stream>();
        List<Bitmap> images = new List<Bitmap>();
        int compteur = 0;

        public tutoQueFaitLeRoi()
        {
            InitializeComponent();
            QueFaitLeRoi_Load();
            timer1.Enabled = true;
            button3.Enabled = false;
        }

        private void QueFaitLeRoi_Load()
        {
            audio.Add(items.roiRentreAuChateauFR);
            audio.Add(items.roiVaALecoleTurc);
            images.Add(items.chateau1);
            images.Add(items.ecole1);
            this.Enabled = true;

            button1.Tag = "1";
            button1.Text = "Le roi rentre au château.";
            button2.Tag = "2";
            button2.Text = "Kral okula girer.";

            pictureBox1.Image = items.chateau1;
            pictureBox2.Image = items.ecole1;

            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.BorderStyle = BorderStyle.FixedSingle;
                image.Image = null;
                image.Enabled = true;
                coordonneesCarteAPlacer.Add(image.Location);
            }
            

            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Visible = true;
                image.Enabled = true;
                coordonneesCarte.Add(image.Location);
            }
            

            foreach (Button bouton in conteneurBouton.Controls)
            {
                bouton.Enabled = true;
                coordonneesBouton.Add(bouton.Location);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            if (compteur < 2)
            {
                conteneurBouton.Controls[compteur].Focus();
                Program.petiteBoite.JouerSon(audio.ElementAt(compteur));
                conteneurCarteAPlacer.Controls.OfType<PictureBox>().ElementAt(compteur).Image = images.ElementAt(compteur);
                conteneurCarte.Controls[compteur].Hide();
                Program.petiteBoite.JouerSon(items.applaudissement);
                compteur++;
            }
            else
            {
                timer1.Enabled = false;
                button3.Enabled = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
