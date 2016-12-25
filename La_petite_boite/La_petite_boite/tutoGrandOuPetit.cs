using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Media;
using Ressources;

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
        List<Stream> audio = new List<Stream>();
        List<Bitmap> images = new List<Bitmap>();

        Assembly _assembly = Assembly.GetExecutingAssembly();

        int compteur = 0;
        int seconds = 0;
        

        public tutoGrandOuPetit()
        {
            InitializeComponent();
            chargementPartie();
            System.Threading.Thread.Sleep(4000);
            conteneurGrandeCarte.Controls.OfType<PictureBox>().ElementAt(0).Image = images.ElementAt(0);
            Program.petiteBoite.JouerSon(audio.ElementAt(0));
        }
        
        private void chargementPartie()
        {
            audio.Add(items.grandChateauTurc);
            audio.Add(items.grandCoffreFR);
            audio.Add(items.petitChateauTurc);
            audio.Add(items.petitCoffreFR);

            images.Add(items.chateau1);
            images.Add(items.coffre1);
            images.Add(items.chateau1);
            images.Add(items.coffre1);
            this.Enabled = true;
            button1.Enabled = false;

            //récupérer les localisations des grandes cartes
            foreach (PictureBox image in conteneurGrandeCarte.Controls)
            {
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.Image = items.dosCarte;
                image.Enabled = true;
            }
            
            //récupérer les localisations des emplacements
            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.Enabled = true;
                image.AllowDrop = false;
                image.Image = null;
                image.BorderStyle = BorderStyle.FixedSingle;
            }
            
            //récupérer les localisations des petites cartes
            foreach (PictureBox image in conteneurPetiteCarte.Controls)
            {
                image.Enabled = true;
                image.Visible = true;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.Image = items.dosCarte;
            }

           /* //timer1.Enabled = true;
            conteneurGrandeCarte.Controls.OfType<PictureBox>().ElementAt(0).Image = images.ElementAt(0);
            Program.petiteBoite.JouerSon(audio.ElementAt(0));
            //System.Threading.Thread.Sleep(2000);
            conteneurPetiteCarte.Controls.OfType<PictureBox>().ElementAt(0).Image = images.ElementAt(0);
            Program.petiteBoite.JouerSon(audio.ElementAt(2));
            //System.Threading.Thread.Sleep(2000);
            conteneurPetiteCarte.Controls[0].Hide();
            //System.Threading.Thread.Sleep(2000);
            conteneurCarteAPlacer.Controls.OfType<PictureBox>().ElementAt(0).Image = images.ElementAt(0);*/
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (compteur < 2)
            {
                //lecture d-une carte de la premiere ligne + son
                conteneurGrandeCarte.Controls.OfType<PictureBox>().ElementAt(compteur).Image = images.ElementAt(compteur);
                Program.petiteBoite.JouerSon(audio.ElementAt(compteur));

                

                if (compteur == 0)
                {
                    //lecture de la premiere carte de la ligne du bas
                    //timer2.Enabled = true;
                    conteneurGrandeCarte.Controls.OfType<PictureBox>().ElementAt(compteur).Image = images.ElementAt(2);
                    //timer2.Enabled = true;
                    //on retourne la carte
                    conteneurGrandeCarte.Controls.OfType<PictureBox>().ElementAt(compteur).Image = items.dosCarte;
                    //timer2.Enabled = true;
                    //lecture de la deuxieme carte
                    conteneurGrandeCarte.Controls.OfType<PictureBox>().ElementAt(1).Image = images.ElementAt(3);
                    //timer2.Enabled = true;
                    //on retourne la carte
                    conteneurGrandeCarte.Controls.OfType<PictureBox>().ElementAt(1).Image = items.dosCarte;
                }

                //timer2.Enabled = true;
                conteneurGrandeCarte.Controls.OfType<PictureBox>().ElementAt(compteur).Image = images.ElementAt(compteur+2);
                //timer2.Enabled = true;
                conteneurPetiteCarte.Controls[compteur].Hide();
                //timer2.Enabled = true;
                conteneurGrandeCarte.Controls.OfType<PictureBox>().ElementAt(compteur).Image = images.ElementAt(compteur + 2);
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
