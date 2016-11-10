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

namespace La_petite_boite
{
    public partial class tutoGrandOuPetit : Form
    {
        private System.Windows.Forms.Panel conteneurGrandeCarte;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel conteneurCarteAPlacer;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel conteneurPetiteCarte;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;

        Random localisationGrandeCarte = new Random();
        Random localisationCarteAPlacer = new Random();
        Random localisationPetiteCarte = new Random();
        List<Point> coordonneesGrandeCarte = new List<Point>(); //liste des localisations des PictureBox
        List<Point> coordonneesCarteAPlacer = new List<Point>(); //liste des localisations des PictureBox
        List<Point> coordonneesPetiteCarte = new List<Point>(); //liste des localisations des PictureBox
        List<String> audio = new List<String>();
        List<String> images = new List<String>();

        Assembly _assembly = Assembly.GetExecutingAssembly();
        Stream _imageStream;
        Stream _sonStream;
        System.Media.SoundPlayer sound;

        int compteur = 0;
        int seconds = 0;

        public tutoGrandOuPetit()
        {
            InitializeComponent();
            chargementPartie();
            timer1.Enabled = true;
        }

        private void chargementPartie()
        {
            audio.Add("LeGrandChateau.wav");
            audio.Add("LaGrandeBoite.wav");
            images.Add("chateau1.png");
            images.Add("coffre1.png");
            images.Add("chateau3.png");
            images.Add("coffre3.png");
            this.Enabled = true;
            button1.Enabled = false;

            //récupérer les localisations des grandes cartes
            foreach (PictureBox image in conteneurGrandeCarte.Controls)
            {
                chargementImage("carte1.png", image);
                image.Enabled = true;
                coordonneesGrandeCarte.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
            }
            
            //récupérer les localisations des emplacements
            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.Enabled = true;
                image.AllowDrop = false;
                image.Image = null;
                image.BorderStyle = BorderStyle.FixedSingle;
                coordonneesCarteAPlacer.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
            }
            
            //récupérer les localisations des petites cartes
            foreach (PictureBox image in conteneurPetiteCarte.Controls)
            {
                image.Enabled = true;
                image.Visible = true;
                chargementImage("carte1.png", image);
                coordonneesPetiteCarte.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
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
            if (compteur < 2)
            {
                //lecture d-une carte de la premiere ligne + son
                chargementImage(images.ElementAt(compteur), (PictureBox) conteneurGrandeCarte.Controls[compteur]);
                chargementSon(audio.ElementAt(compteur), sound);

                if (compteur == 0)
                {
                    //lecture de la premiere carte de la ligne du bas
                    //timer2.Enabled = true;
                    chargementImage(images.ElementAt(2), (PictureBox)conteneurPetiteCarte.Controls[compteur]);
                    //timer2.Enabled = true;
                    //on retourne la carte
                    chargementImage("carte1.png", (PictureBox)conteneurPetiteCarte.Controls[compteur]);
                    //timer2.Enabled = true;
                    //lecture de la deuxieme carte
                    chargementImage(images.ElementAt(3), (PictureBox)conteneurPetiteCarte.Controls[1]);
                    //timer2.Enabled = true;
                    //on retourne la carte
                    chargementImage("carte1.png", (PictureBox)conteneurPetiteCarte.Controls[1]);
                }

                //timer2.Enabled = true;
                chargementImage(images.ElementAt(compteur+2), (PictureBox) conteneurPetiteCarte.Controls[compteur]);
                //timer2.Enabled = true;
                conteneurPetiteCarte.Controls[compteur].Hide();
                //timer2.Enabled = true;
                chargementImage(images.ElementAt(compteur+2), (PictureBox) conteneurCarteAPlacer.Controls[compteur]);
                compteur++;
            }
            else
            {
                timer1.Enabled = false;
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //ce timer ne sert qu'a stopper l'execution de certaines actions

            if (seconds <5)
            {
                seconds++;
            }
            else
            {
                timer2.Enabled = false;
            }
        }
    }
}
