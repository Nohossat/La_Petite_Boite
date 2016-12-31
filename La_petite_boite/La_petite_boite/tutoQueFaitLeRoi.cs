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
    public partial class tutoQueFaitLeRoi : PopForm
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
        
        List<Stream> audio = new List<Stream>();
        List<Bitmap> images = new List<Bitmap>();
        public int compteur = 0;

        public tutoQueFaitLeRoi() : base()
        {
            InitializeComponent();

            conteneur.Controls.Add(this.conteneurBouton);
            conteneur.Controls.Add(this.conteneurCarteAPlacer);
            conteneur.Controls.Add(this.conteneurCarte);

            this.conteneurCarte.Location = new System.Drawing.Point(160, 230);
            this.conteneurCarteAPlacer.Location = new System.Drawing.Point(160, 80);
            this.conteneurBouton.Location = new System.Drawing.Point(160, 30);

            tableauFonctions.Add(action1);
            tableauFonctions.Add(action2);
            tableauFonctions.Add(action3);
            tableauFonctions.Add(action4);

            chargementPartie();

            System.Threading.Thread.Sleep(1000);
            timer2.Enabled = true;
        }
        
        private void chargementPartie()
        {
            audio.Add(items.roiRentreAuChateauFR);
            audio.Add(items.roiVaALecoleTurc);
            images.Add(items.ecole1);
            images.Add(items.chateau1);
            
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
                image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Visible = true;
                image.Enabled = true;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.BackColor = Color.White;
            }
            

            foreach (Button bouton in conteneurBouton.Controls)
            {
                bouton.Enabled = true;
            }
        }

        private void action1()
        {
            //on ecoute la premiere phrase
            Program.petiteBoite.JouerSon(audio.ElementAt(0));
        }

        private void action2()
        {
            //on survole la premiere carte
            Program.petiteBoite.JouerSon(items.ecoleFR);
        }

        private void action3()
        {
            //on survole la deuxieme carte
            Program.petiteBoite.JouerSon(items.chateauTurc);
        }

        private void action4()
        {
            //on met la bonne carte au bon emplacement
            conteneurCarteAPlacer.Controls.OfType<PictureBox>().ElementAt(0).Image = images[1];
            conteneurCarteAPlacer.Controls.OfType<PictureBox>().ElementAt(0).BackColor = Color.White;
            conteneurCarte.Controls.OfType<PictureBox>().ElementAt(0).Hide();
            Refresh();
        }
        
    }
}
