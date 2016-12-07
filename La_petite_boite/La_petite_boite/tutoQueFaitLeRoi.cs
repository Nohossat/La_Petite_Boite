using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
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
        Assembly _assembly = Assembly.GetExecutingAssembly();
        Stream _imageStream;
        Stream _sonStream;
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

            chargementImage("chateau1.png", pictureBox1);
            chargementImage("ecole1.png", pictureBox2);

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
        
        public void chargementImage(String res, PictureBox p)
        {
            //access resource
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("La_petite_boite.Resources.miniJeu." + res);
                Console.WriteLine(res);
            }
            catch
            {
                Console.WriteLine("Error accessing resources!");
            }

            //display image
            try
            {
                p.Image = new Bitmap(_imageStream);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cant create image for picturebox!" + e);
            }
        }

        public void chargementSon(String res, System.Media.SoundPlayer son)
        {
            //access resource
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _sonStream = _assembly.GetManifestResourceStream("La_petite_boite.Resources.miniJeu." + res);
                Console.WriteLine(res);
            }
            catch
            {
                Console.WriteLine("Error accessing resources!");
            }

            //play sound
            try
            {
                son = new System.Media.SoundPlayer(_sonStream);
                son.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine("Cant play the sound" + e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            if (compteur < 2)
            {
                conteneurBouton.Controls[compteur].Focus();
                chargementSon(audio.ElementAt(compteur), sound);
                chargementImage(images.ElementAt(compteur), (PictureBox)conteneurCarteAPlacer.Controls[compteur]);
                conteneurCarte.Controls[compteur].Hide();
                chargementSon("applaudissements.wav", sound);
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
