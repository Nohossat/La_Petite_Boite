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
        public Button Valider = new Button();
        public Button Annuler = new Button();
        public List<Stream> sons = new List<Stream>();
        public List<Bitmap> img = new List<Bitmap>();
        
        
        public new void lancement()
        {

        }

        public new void chargementPartie()
        {
            //conteneur des boutons Valider et Annuler
            conteneurBoutons.Size = new Size(180, 70);
            conteneurBoutons.Top = (Height/2)-35;
            conteneurBoutons.Left = 0;
            conteneurBoutons.BackColor = Color.SlateGray;
            conteneurBoutons.Controls.Add(Valider);
            conteneurBoutons.Controls.Add(Annuler);
            conteneurCarte.Location = new Point(200, 0);
            conteneurCarte.Name = "conteneurCarte";

            //le panel contient le conteneurBoutons et le conteneurCartes
            this.Controls.Add(conteneurBoutons);
            this.Controls.Add(this.conteneurCarte);
            this.Location = new Point(0, 0);
            this.Name = "Memory";
            
            //configuration des boutons du conteneurBoutons
            Valider.Location = new Point(20, 5);
            Valider.BackgroundImage = items.check;
            Valider.Click += new EventHandler(ValiderButton);

            Annuler.Location = new Point(100, 5);
            Annuler.BackgroundImage = items.faux;
            Annuler.Click += new EventHandler(AnnulerButton);
            
            foreach (Button b in conteneurBoutons.Controls)
            {
                b.UseCompatibleTextRendering = true;
                b.FlatAppearance.BorderSize = 0;
                b.TabStop = false;
                b.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
                b.BackColor = Color.Transparent;
                b.FlatStyle = FlatStyle.Flat;
                b.BackgroundImageLayout = ImageLayout.Center;
                b.Size = new Size(60, 60);
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
                //si les deux derneires cartes ont ete selectionnees
                if (this.score == 3 && ImageEnAttente1 != null && ImageEnAttente2 != null)
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
