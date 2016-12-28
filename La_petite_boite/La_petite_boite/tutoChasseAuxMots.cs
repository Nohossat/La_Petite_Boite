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
    public partial class tutoChasseAuxMots : PopForm
    {
        public Panel conteneurCarte;
        public PictureBox pictureBox2;
        public PictureBox pictureBox1;
        public Button Ecouter;
        
        List<Stream> sounds = new List<Stream>();
        
        public tutoChasseAuxMots() : base()
        {
            InitializeComponent();
            ChasseAuxMots_Load();
            System.Threading.Thread.Sleep(1000);
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
            //on clique sur Ecouter
            Program.petiteBoite.JouerSon(sounds.ElementAt(0));
            //le bouton Ecouter est disabled
            Ecouter.Enabled = false;
            //on clique dessus et elle se retourne
            System.Threading.Thread.Sleep(1000);
            pictureBox1.Image = items.dosCarte;
            System.Threading.Thread.Sleep(500);
            Program.petiteBoite.JouerSon(items.applaudissement);
            //on arrete le timer et on active le jeu
            timer1.Enabled = false;
        }
        
    }
}
