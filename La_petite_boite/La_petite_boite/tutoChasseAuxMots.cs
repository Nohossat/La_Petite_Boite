using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Media;

namespace La_petite_boite
{
    public partial class tutoChasseAuxMots : Form
    {
        private Panel conteneurCarte;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button Ecouter;

        Random localisation = new Random(); //
        List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox
        List<String> sounds = new List<String>();
        SoundPlayer son = new SoundPlayer();

        int compteur = 0;

        public tutoChasseAuxMots()
        {
            InitializeComponent();
            ChasseAuxMots_Load();
            timer1.Enabled = true;
        }

        private void ChasseAuxMots_Load()
        {
            this.Enabled = true;
            Ecouter.Enabled = true;
            Program.petiteBoite.chargementImage("doudou1.png", "miniJeu", pictureBox1);
            Program.petiteBoite.chargementImage("jardin1.png", "miniJeu", pictureBox2);
            sounds.Add("UnDoudou.wav");
            sounds.Add("Bahce.wav");
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (compteur < 2)
            {
                Program.petiteBoite.chargementSon(sounds.ElementAt(compteur), "miniJeu", son);
                Program.petiteBoite.chargementImage("carte1.png", "miniJeu", (PictureBox)conteneurCarte.Controls[compteur]);
                Program.petiteBoite.chargementSon("applaudissements.wav", "miniJeu", son);
                compteur++;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
