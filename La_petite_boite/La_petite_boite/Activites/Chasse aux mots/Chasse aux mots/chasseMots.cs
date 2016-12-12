using Ressources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chasse_aux_mots
{
    public class chasseMots : Jeu.Jeu
    {
        public int score = 0;
        public int index;
        public Panel conteneurCarte;
        public String carteACliquerTag;
        public String imageCliqueTag;
        public Random localisation = new Random();
        public List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox
        public List<Stream> sons = new List<Stream>();
        public Button Ecouter;

        public chasseMots ()
        {

        }

        private new void chargementPartie()
        {

        }

        public void AffichageDosCarte(PictureBox img, ref Boolean trouve)
        {
            img.Image = items.dosCarte;
            trouve = true;
        }

        public void JouerSon(Stream stream, int choix, ref String tag)
        {
            stream.Position = 0;
            SoundPlayer son = new SoundPlayer(stream);
            son.Play();
            tag = choix.ToString();
            son.Dispose();
        }

        public void reponse(int score, PictureBox img, ref Boolean trouve)
        {
            if (imageCliqueTag == carteACliquerTag)
            {
                JouerSon(items.applaudissement);
                AffichageDosCarte(img, ref trouve);
                img.Enabled = false;
                score++;

                if (this.score == score)
                {
                    MessageBox.Show("Bien joué, tu as fini la partie !", "Bravo !");
                    Ecouter.Enabled = false;
                    this.Enabled = false;
                }
            }
            else
            {
                JouerSon(items.pouet);
            }
        }
        
    }
}
