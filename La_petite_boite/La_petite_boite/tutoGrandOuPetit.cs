using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Media;
using Ressources;
using System.Threading;

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

            tableauFonctions.Add(action1);
            tableauFonctions.Add(action2);
            tableauFonctions.Add(action3);
            tableauFonctions.Add(action4);
            tableauFonctions.Add(action5);
            
            this.conteneurPetiteCarte.Location = new Point(160, 280);
            this.conteneurCarteAPlacer.Location = new Point(160, 140);
            this.conteneurGrandeCarte.Location = new Point(160, 0);

            conteneur.Controls.Add(this.conteneurPetiteCarte);
            conteneur.Controls.Add(this.conteneurCarteAPlacer);
            conteneur.Controls.Add(this.conteneurGrandeCarte);

            chargementPartie();
            Thread.Sleep(1000);
            timer2.Enabled = true;
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
        
        private void action1 ()
        {
            //on met la souris sur la premiere grande carte
            p.x = 115;
            p.y = 3;

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);
            //on devoile la premiere grde carte
            conteneurGrandeCarte.Controls.OfType<PictureBox>().ElementAt(0).Image = images[0];
            conteneurGrandeCarte.Controls.OfType<PictureBox>().ElementAt(0).BackColor = Color.White;
            Refresh();
            Program.petiteBoite.JouerSon(audio.ElementAt(0));
        }

        private void action2 ()
        {
            //on met la souris sur la premiere pt carte
            p.x = 3;
            p.y = 3;

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);

            //on devoile la premiere pt carte
            conteneurPetiteCarte.Controls.OfType<PictureBox>().ElementAt(1).Image = images[1];
            conteneurPetiteCarte.Controls.OfType<PictureBox>().ElementAt(1).BackColor = Color.White;
            Refresh();
            Program.petiteBoite.JouerSon(audio.ElementAt(3));
        }

        private void action3 ()
        {
            
            //on retourne la premiere pt carte
            conteneurPetiteCarte.Controls.OfType<PictureBox>().ElementAt(1).Image = items.dosCarte;
            conteneurPetiteCarte.Controls.OfType<PictureBox>().ElementAt(1).BackColor = Color.Transparent;
            Refresh();
        }

        private void action4 ()
        {
            // on met la souris sur la deuxieme pt carte
            p.x = 115;
            p.y = 3;

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);

            //on devoile la deuxieme pt carte
            conteneurPetiteCarte.Controls.OfType<PictureBox>().ElementAt(0).Image = images[0];
            conteneurPetiteCarte.Controls.OfType<PictureBox>().ElementAt(0).BackColor = Color.White;
            Refresh();
            Program.petiteBoite.JouerSon(audio.ElementAt(2));
        }

        private void action5 ()
        {
            conteneurCarteAPlacer.Controls.OfType<PictureBox>().ElementAt(0).Image = images[0];
            conteneurCarteAPlacer.Controls.OfType<PictureBox>().ElementAt(0).BackColor = Color.White;
            conteneurPetiteCarte.Controls.OfType<PictureBox>().ElementAt(0).Hide();
            Refresh();
        }
        
    }
}
