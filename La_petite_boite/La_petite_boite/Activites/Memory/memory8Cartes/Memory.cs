using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ressources;
using System.IO;
using Jeu;

namespace memory8Cartes
{
    public class Memory : Jeu.Jeu
    {
        public int score;
        public int finalScore;
        public Random localisation = new Random(); //
        public List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox
        public PictureBox ImageEnAttente1; //la première carte sélectionnée
        public PictureBox ImageEnAttente2; //la deuxième carte sélectionnée
        public Panel conteneurCarte;
        public List<Stream> sons = new List<Stream>();
        public List<Bitmap> img = new List<Bitmap>();
        
        
        public new void lancement()
        {

        }

        public new void chargementPartie()
        {
            score = 0;
            this.ImageEnAttente1 = null; //initialisation à null
            this.ImageEnAttente2 = null; //initialisation à null
            this.Enabled = true;

            foreach (PictureBox image in this.conteneurCarte.Controls)
            {
                image.Enabled = true;
                image.Image = items.dosCarte;
                //récupérer les localisations des cartes
                coordonneesCartes.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
            }

            //mélange des cartes
            foreach (PictureBox image in this.conteneurCarte.Controls)
            {
                int next = localisation.Next(coordonneesCartes.Count);
                Point p = coordonneesCartes[next];
                image.Location = p;
                coordonneesCartes.Remove(p);
            }
        }
        
        public void chargementData(PictureBox pic, Bitmap img, Stream str)
        {
            pic.BackColor = Color.White;
            pic.Image = img;
            JouerSon(str);
        }
        
        public void jouer(object sender, EventArgs e)
        {
            int index;
            PictureBox carteCourante = (PictureBox)sender;

            index = Int32.Parse((String)carteCourante.Tag) - 1;

            //attribution des mots pour chaque paires selon le tag 

            chargementData(carteCourante, img[index], sons[index]);

            DialogResult rep;

            //contrôles sur les cartes sélectionnées
            if (ImageEnAttente1 == null)
            {
                ImageEnAttente1 = carteCourante;
                ImageEnAttente1.Enabled = false; //évite le fait de pouvoir cliquer 2 fois sur une carte       
            }
            else if (ImageEnAttente1 != null && ImageEnAttente2 == null)
            {
                ImageEnAttente2 = carteCourante;
                ImageEnAttente1.Enabled = true;
            }

            if (ImageEnAttente1 != null && ImageEnAttente2 != null)
            {
                if (ImageEnAttente1.Tag == ImageEnAttente2.Tag)
                {
                    rep = MessageBox.Show("As-tu entendu la même chose ?", "Memory", MessageBoxButtons.YesNo);

                    if (rep == DialogResult.Yes)
                    {
                        JouerSon(items.applaudissement);

                        ImageEnAttente1.Enabled = false;
                        ImageEnAttente2.Enabled = false;

                        ImageEnAttente1 = null;
                        ImageEnAttente2 = null;

                        this.score++;
                    }
                    else
                    {
                        JouerSon(items.pouet);
                        MessageBox.Show("En est-tu sûr ? Ré-essaye !");
                        ImageEnAttente1.Image = items.dosCarte;
                        ImageEnAttente2.Image = items.dosCarte;
                        ImageEnAttente1 = null;
                        ImageEnAttente2 = null;
                    }
                }
                else
                {
                    rep = MessageBox.Show("As-tu entendu la même chose ?", "Memory", MessageBoxButtons.YesNo);

                    if (rep == DialogResult.Yes)
                    {
                        if (ImageEnAttente1.Tag != ImageEnAttente2.Tag)
                        {
                            JouerSon(items.pouet);
                            MessageBox.Show("Les sons ne sont pas les mêmes... Ré-essaye !");
                        }
                    }

                    ImageEnAttente1.Image = items.dosCarte;
                    ImageEnAttente2.Image = items.dosCarte;
                    ImageEnAttente1.BackColor = Color.Transparent;
                    ImageEnAttente2.BackColor = Color.Transparent;
                    ImageEnAttente1 = null;
                    ImageEnAttente2 = null;
                }
            }
            
            if (this.score == finalScore)
            {
                this.Enabled = false;
                chargementPartie();
            }
        }

        
    }
}
