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
        public bouton1 Ecouter;
        
        List<Stream> sounds = new List<Stream>();
        
        public tutoChasseAuxMots() : base()
        {
            InitializeComponent();

            this.Ecouter.Font = new Font(petiteBoite.privateFontCollection.Families[0], 17);
            this.Ecouter.Location = new Point(174, 265);
            this.conteneurCarte.Location = new Point(120, 40);

            conteneur.Controls.Add(this.Ecouter);
            conteneur.Controls.Add(this.conteneurCarte);

            tableauFonctions.Add(action1);
            tableauFonctions.Add(action2);

            chargementPartie();
            System.Threading.Thread.Sleep(1000);
            timer2.Enabled = true;
        }

        private void chargementPartie()
        {
            this.Enabled = true;
            Ecouter.Enabled = true;
            pictureBox1.Image = items.doudou1;
            pictureBox2.Image = items.jardin1;

            sounds.Add(items.doudouFR);
            sounds.Add(items.jardinTurc);
        }

        private void action1 ()
        {
            //on clique sur Ecouter
            Program.petiteBoite.JouerSon(sounds.ElementAt(0));
            //le bouton Ecouter est disabled
            Ecouter.Enabled = false;
            //on clique dessus et elle se retourne
        }

        private void action2()
        {
            pictureBox1.Image = items.dosCarte;
        }
        
    }


}
