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
        public int indexCarte;
        public int index;
        public Random localisation = new Random(); //
        public List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox
        public PictureBox ImageEnAttente1; //la première carte sélectionnée
        public PictureBox ImageEnAttente2; //la deuxième carte sélectionnée
        public Panel conteneurCarte;
        public Panel conteneurBoutons = new Panel();
        public PictureBox Valider = new PictureBox();
        public PictureBox Annuler = new PictureBox();
        public List<Stream> sons = new List<Stream>();
        public List<Bitmap> img = new List<Bitmap>();
        public List<Bitmap> imagesEnterBoutons = new List<Bitmap>();
        public List<Bitmap> imagesLeaveBoutons = new List<Bitmap>();

        public new void lancement()
        {

        }

        public new void chargementPartie()
        {
            this.BackgroundImage = items.fondBlanc;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //conteneur des boutons Valider et Annuler
            conteneurBoutons.Size = new Size(180, 70);
            conteneurBoutons.Top = (Height/2)-35;
            conteneurBoutons.Left = 0;
            conteneurBoutons.BackColor = Color.Transparent;
            conteneurBoutons.Controls.Add(Valider);
            conteneurBoutons.Controls.Add(Annuler);

            conteneurCarte.Location = new Point(200, 5);
            conteneurCarte.Name = "conteneurCarte";
            conteneurCarte.BackColor = Color.Transparent;

            imagesEnterBoutons.Add(items.checkHover);
            imagesEnterBoutons.Add(items.fauxHover);

            imagesLeaveBoutons.Add(items.check);
            imagesLeaveBoutons.Add(items.faux);

            //le panel contient le conteneurBoutons et le conteneurCartes
            this.Controls.Add(conteneurBoutons);
            this.Controls.Add(conteneurCarte);
            this.Location = new Point(0, 0);
            this.Name = "Memory";
            
            //configuration des boutons du conteneurBoutons
            Valider.Location = new Point(20, 5);
            Valider.Image = imagesLeaveBoutons[0];
            Valider.Click += new EventHandler(ValiderButton);
            Valider.MouseEnter += new EventHandler(boutonEnter);
            Valider.MouseLeave += new EventHandler(boutonLeave);

            Annuler.Location = new Point(100, 5);
            Annuler.Image = imagesLeaveBoutons[1];
            Annuler.Click += new EventHandler(AnnulerButton);
            Annuler.MouseEnter += new EventHandler(boutonEnter);
            Annuler.MouseLeave += new EventHandler(boutonLeave);

            foreach (PictureBox b in conteneurBoutons.Controls)
            {
                b.TabStop = false;
                b.BackColor = Color.Transparent;
                b.SizeMode = PictureBoxSizeMode.StretchImage;
                b.Size = new Size(60, 60);
                b.Cursor = Cursors.Hand;
            }
            
            //initialisation du score a 0
            score = 0;
            //compteur necessaire pour le placement des cartes
            indexCarte = 0;
            //initialisation des flags 
            this.ImageEnAttente1 = null; 
            this.ImageEnAttente2 = null;
            this.Enabled = true;

            //placement des cartes selon leur nombre
            foreach (PictureBox image in this.conteneurCarte.Controls)
            {
                image.Enabled = true;
                image.Image = items.dosCarte;
                image.Cursor = Cursors.Hand;
                image.Size = new Size(130, 160);
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.TabStop = false;
                image.Click += new EventHandler(this.jouer);
                image.BackColor = Color.Transparent;

                //locations for Memory8
                if (conteneurCarte.Controls.Count == 8)
                {
                    if (indexCarte < 4)
                    {
                        image.Left = indexCarte * 153;
                        image.Top = 15;
                    }
                    else
                    {
                        image.Left = (indexCarte - 4) * 153;
                        image.Top = 194;
                    }
                }//locations for Memory12
                else if (conteneurCarte.Controls.Count == 12)
                {
                    if (indexCarte < 4)
                    {
                        image.Left = indexCarte * 135;
                        image.Top = 3;
                    }
                    else if (indexCarte < 8)
                    {
                        image.Left = (indexCarte - 4) * 135;
                        image.Top = 169;
                    }
                    else
                    {
                        image.Left = (indexCarte - 8) * 135;
                        image.Top = 335;
                    }
                }//locations for Memory18
                else if (conteneurCarte.Controls.Count == 18)
                {
                    if (indexCarte < 6)
                    {
                        image.Left = indexCarte * 135;
                        image.Top = 3;
                    }
                    else if (indexCarte < 12)
                    {
                        image.Left = (indexCarte - 6) * 135;
                        image.Top = 169;
                    }
                    else
                    {
                        image.Left = (indexCarte - 12) * 135;
                        image.Top = 335;
                    }
                }
                indexCarte++;
                //on recupere les localisations des cartes pour pouvoir les melanger ensuite
                coordonneesCartes.Add(image.Location);
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

        private void boutonLeave(object sender, EventArgs e)
        {
            PictureBox boutonTabBord = (PictureBox)sender;

            //on determine quelle est la position dans la liste des imgEnter pour determiner l'indice de l'image Leave a montrer
            Bitmap img = (Bitmap)boutonTabBord.Image;

            int index = imagesEnterBoutons.IndexOf(img);

            boutonTabBord.Image = imagesLeaveBoutons[index];
        }

        private void boutonEnter(object sender, EventArgs e)
        {
            PictureBox boutonTabBord = (PictureBox)sender;

            //on determine quelle est la position dans la liste des imgLeave pour determiner l'indice de l'image Enter a montrer
            Bitmap img = (Bitmap)boutonTabBord.Image;

            int index = imagesLeaveBoutons.IndexOf(img);

            boutonTabBord.Image = imagesEnterBoutons[index];
        }

        public void chargementData(PictureBox pic, Bitmap img, Stream str)
        {
            pic.BackColor = Color.White;
            pic.Image = img;
            JouerSon(str);
        }
        
        public void jouer(object sender, EventArgs e)
        {//si les deux cartes sont deja selectionnees, on ne peut pas en selectionner une troisieme
            if (ImageEnAttente1 == null || ImageEnAttente2 == null)
            {
                PictureBox carteCourante = (PictureBox)sender;

                index = Int32.Parse((String)carteCourante.Tag) - 1;

                //attribution des mots, images et sons pour chaque paires selon le tag 

                chargementData(carteCourante, img[index], sons[index]);
            
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
                //si les deux dernieres cartes ont ete selectionnees
                if (this.score == (finalScore-1) && ImageEnAttente1 != null && ImageEnAttente2 != null)
                {
                    JouerSon(items.applaudissement);
                    ImageEnAttente1.Enabled = false;
                    ImageEnAttente2.Enabled = false;
                    this.score++;
                    this.Enabled = false;
                    //on fait une pause pour que l-enfant comprenne les derniers mot/image reveles
                    System.Threading.Thread.Sleep(5000);
                    chargementPartie();
                }
            }
        }

        public void ValiderButton (object sender, EventArgs e)
        {
            //si deux cartes sont selectionnees
            if (ImageEnAttente1 != null && ImageEnAttente2 != null)
            {
                if (ImageEnAttente1.Tag == ImageEnAttente2.Tag)
                {
                    JouerSon(items.applaudissement);
                    ImageEnAttente1.Enabled = false;
                    ImageEnAttente2.Enabled = false;
                    this.score++;
                }
                else
                {
                    JouerSon(items.pouet);
                    ImageEnAttente1.Image = items.dosCarte;
                    ImageEnAttente2.Image = items.dosCarte;
                    ImageEnAttente1.BackColor = Color.Transparent;
                    ImageEnAttente2.BackColor = Color.Transparent;
                }
                ImageEnAttente1 = null;
                ImageEnAttente2 = null;
            }
        }

        public void AnnulerButton (object sender, EventArgs e)
        {
            if (ImageEnAttente1 != null && ImageEnAttente2 != null)
            {
                ImageEnAttente1.Image = items.dosCarte;
                ImageEnAttente2.Image = items.dosCarte;
                ImageEnAttente1.BackColor = Color.Transparent;
                ImageEnAttente2.BackColor = Color.Transparent;
                ImageEnAttente1 = null;
                ImageEnAttente2 = null;
            }
        }
    }
}
