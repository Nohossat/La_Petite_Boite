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
    public partial class tutoChasseAuxMots : Form
    {
        public Panel conteneurCarte;
        public PictureBox pictureBox2;
        public PictureBox pictureBox1;
        public Button Ecouter;
        
        List<Stream> sounds = new List<Stream>();
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
            pictureBox1.Image = items.doudou1;
            pictureBox2.Image = items.jardin1;

            sounds.Add(items.doudouFR);
            sounds.Add(items.jardinTurc);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Ecouter.Select();
            Program.petiteBoite.JouerSon(sounds.ElementAt(0));
            conteneurCarte.Controls.OfType<PictureBox>().ElementAt(0).Image = items.dosCarte;
            Program.petiteBoite.JouerSon(items.applaudissement);

            /*if (compteur < 2)
            {
                Program.petiteBoite.JouerSon(sounds.ElementAt(compteur));
                conteneurCarte.Controls.OfType<PictureBox>().ElementAt(compteur).Image = items.dosCarte;
                Program.petiteBoite.JouerSon(items.applaudissement);
                compteur++;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
