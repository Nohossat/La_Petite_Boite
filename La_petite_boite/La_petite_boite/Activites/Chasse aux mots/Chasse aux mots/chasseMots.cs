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
        public int finalScore;
        public int index;
        public Panel conteneurCarte;
        public String carteACliquerTag;
        public String imageCliqueTag;
        public Random localisation = new Random();
        public List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox
        public List<Stream> sons = new List<Stream>();
        public Button Ecouter;
        public Boolean[] trouves;

        public chasseMots ()
        {

        }

        public new void chargementPartie()
        {
            this.Enabled = true;
            Ecouter.Enabled = true;
            carteACliquerTag = "";
            imageCliqueTag = "";

            //récupérer les localisations des cartes
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Enabled = true;
                coordonneesCartes.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
            }

            //mélange des cartes
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                int next = localisation.Next(coordonneesCartes.Count);
                Point p = coordonneesCartes[next];
                image.Location = p;
                coordonneesCartes.Remove(p);
            }
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
                this.score++;

                if (this.score == finalScore)
                {
                    Ecouter.Enabled = false;
                    this.Enabled = false;
                    chargementPartie();
                }
            }
            else
            {
                JouerSon(items.pouet);
            }
        }

        public void CliquerReponse(object sender, EventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            imageCliqueTag = (String)image.Tag;

            reponse(finalScore, image, ref trouves[index]);
        }

    }
}
