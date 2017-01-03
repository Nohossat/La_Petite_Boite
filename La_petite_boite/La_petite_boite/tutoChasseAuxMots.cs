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
            Ecouter.Cursor = Cursors.Hand;
           
            //on met la souris sur le bouton Ecouter
            p.x = Ecouter.Location.X + 130;
            p.y = Ecouter.Location.Y + 130;

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);

           //on clique sur Ecouter
            Program.petiteBoite.JouerSon(sounds.ElementAt(0));
            //le bouton Ecouter est disabled
            Ecouter.Enabled = false;
            //on clique dessus et elle se retourne
        }

        private void action2()
        {
            pictureBox1.Cursor = Cursors.Hand;
            //on met la souris sur la carte
            p.x = pictureBox1.Location.X + 200;
            p.y = pictureBox1.Location.Y + 200;

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);
            pictureBox1.Image = items.dosCarte;
        }
        
    }


}
