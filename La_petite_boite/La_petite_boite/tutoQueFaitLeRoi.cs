using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;

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
        List<String> audio = new List<String>();
        List<String> images = new List<String>();
        int compteur = 0;

        public tutoQueFaitLeRoi()
        {
            InitializeComponent();
            Cursor myCursor = new Cursor("../../Resources/Jeu/souris.cur");
            this.Cursor = myCursor;
            QueFaitLeRoi_Load();
            timer1.Enabled = true;
            button3.Enabled = false;
        }

        private void QueFaitLeRoi_Load()
        {
            audio.Add("leRoiRentreAuChateau.wav");
            audio.Add("kralOkulaGirer.wav");
            images.Add("chateau1.png");
            images.Add("ecole1.png");
            this.Enabled = true;

            button1.Tag = "1";
            button1.Text = "Le roi rentre au château.";
            button2.Tag = "2";
            button2.Text = "Kral okula girer.";

            Program.petiteBoite.chargementImage("chateau1.png", "miniJeu", pictureBox1);
            Program.petiteBoite.chargementImage("ecole1.png", "miniJeu", pictureBox2);

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
                Program.petiteBoite.chargementSon(audio.ElementAt(compteur), "miniJeu", sound);
                Program.petiteBoite.chargementImage(images.ElementAt(compteur), "miniJeu", (PictureBox)conteneurCarteAPlacer.Controls[compteur]);
                conteneurCarte.Controls[compteur].Hide();
                Program.petiteBoite.chargementSon("applaudissements.wav", "miniJeu", sound);
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
