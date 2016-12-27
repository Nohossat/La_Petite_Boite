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
        
        List<Stream> audio = new List<Stream>();
        List<Bitmap> images = new List<Bitmap>();
        public int compteur = 0;

        public tutoQueFaitLeRoi()
        {
            InitializeComponent();
            QueFaitLeRoi_Load();
            System.Threading.Thread.Sleep(2000);
            timer1.Enabled = true;
        }
        
        
        private void QueFaitLeRoi_Load()
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
            }
            
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Visible = true;
                image.Enabled = true;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            

            foreach (Button bouton in conteneurBouton.Controls)
            {
                bouton.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point buttonCentre = new Point(button3.Width / 2, button3.Height / 2);
            Point p = button3.PointToScreen(buttonCentre);
            Cursor.Position = p;

            //on ecoute la premiere phrase
            Program.petiteBoite.JouerSon(audio.ElementAt(0));
            //on survole la premiere carte

            //on survole la deuxieme carte

            //on met la bonne carte au bon emplacement

            timer1.Enabled = false;
            button3.Enabled = true;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
