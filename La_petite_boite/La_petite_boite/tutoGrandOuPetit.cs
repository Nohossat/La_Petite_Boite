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
    public partial class tutoGrandOuPetit : PopForm
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
        
        List<Stream> audio = new List<Stream>();
        List<Bitmap> images = new List<Bitmap>();
        
        public tutoGrandOuPetit() : base()
        {
            InitializeComponent();
            chargementPartie();
            System.Threading.Thread.Sleep(2000);
            timer1.Enabled = true;
        }

        private void chargementPartie()
        {
            //on charge les images et les sons
            audio.Add(items.grandChateauTurc);
            audio.Add(items.grandCoffreFR);
            audio.Add(items.petitChateauTurc);
            audio.Add(items.petitCoffreFR);

            images.Add(items.chateau1);
            images.Add(items.coffre1);
            //this.Enabled = true;
            button1.Enabled = false;

            //grandes cartes
            foreach (PictureBox image in conteneurGrandeCarte.Controls)
            {
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.Image = items.dosCarte;
                image.Enabled = true;
            }

            //emplacements
            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.Enabled = true;
                image.AllowDrop = false;
                image.Image = null;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.BorderStyle = BorderStyle.FixedSingle;
            }

            //petites cartes
            foreach (PictureBox image in conteneurPetiteCarte.Controls)
            {
                image.Enabled = true;
                image.Visible = true;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.Image = items.dosCarte;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //on devoile la premiere grde carte
            conteneurGrandeCarte.Controls.OfType<PictureBox>().ElementAt(0).Image = images[0];
            Refresh();
            Program.petiteBoite.JouerSon(audio.ElementAt(0));
            System.Threading.Thread.Sleep(3000);
            //on devoile la premiere pt carte
            conteneurPetiteCarte.Controls.OfType<PictureBox>().ElementAt(1).Image = images[1];
            Refresh();
            Program.petiteBoite.JouerSon(audio.ElementAt(3));
            System.Threading.Thread.Sleep(2000);
            //on retourne la premiere pt carte
            conteneurPetiteCarte.Controls.OfType<PictureBox>().ElementAt(1).Image = items.dosCarte;
            Refresh();
            System.Threading.Thread.Sleep(2000);
            //on devoile la deuxieme pt carte
            conteneurPetiteCarte.Controls.OfType<PictureBox>().ElementAt(0).Image = images[0];
            Refresh();
            Program.petiteBoite.JouerSon(audio.ElementAt(2));
            System.Threading.Thread.Sleep(2000);
            //on la pose dans l'emplacement
            conteneurCarteAPlacer.Controls.OfType<PictureBox>().ElementAt(0).Image = images[0];
            conteneurPetiteCarte.Controls.OfType<PictureBox>().ElementAt(0).Hide();
            Refresh();
            Program.petiteBoite.JouerSon(items.applaudissement);
            //on la retire du conteneur petite carte
            //on enable le bouton GO
            timer1.Enabled = false;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        
    }
}
