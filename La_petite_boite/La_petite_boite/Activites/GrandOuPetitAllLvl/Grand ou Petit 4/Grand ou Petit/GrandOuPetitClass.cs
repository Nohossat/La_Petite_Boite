using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ressources;
using System.IO;

namespace Grand_ou_Petit
{
    public class GrandOuPetitClass : Jeu.Jeu
    {
        public int score = 0;
        public int finalScore;
        public Random localisationGrandeCarte = new Random();
        public Random localisationCarteAPlacer = new Random();
        public Random localisationPetiteCarte = new Random();
        public List<Point> coordonneesGrandeCarte = new List<Point>(); //liste des localisations des PictureBox
        public List<Point> coordonneesCarteAPlacer = new List<Point>(); //liste des localisations des PictureBox
        public List<Point> coordonneesPetiteCarte = new List<Point>(); //liste des localisations des PictureBox
        public Image petiteImageRecup;
        public Boolean carteRetournee;
        public Boolean cartePetiteDejaSelectionnee;
        public String premiereCarteSelectionnee;
        public String deuxiemeCarteSelectionnee;
        public String destinationCarte;
        public Panel conteneurGrandeCarte;
        public Panel conteneurCarteAPlacer;
        public Panel conteneurPetiteCarte;
        public List<Bitmap> img = new List<Bitmap>();
        public List<Stream> sons = new List<Stream>();

        public GrandOuPetitClass ()
        {
            
        }

        public new void chargementPartie()
        {
            this.Enabled = true;
            carteRetournee = false;
            cartePetiteDejaSelectionnee = false;
            premiereCarteSelectionnee = "";
            deuxiemeCarteSelectionnee = "";
            destinationCarte = "";
            petiteImageRecup = null;

            //récupérer les localisations des grandes cartes
            foreach (PictureBox image in conteneurGrandeCarte.Controls)
            {
                image.Image = items.dosCarte;
                image.Enabled = true;
                coordonneesGrandeCarte.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
                image.Click += new System.EventHandler(this.cliquerPremiereLigne);
            }

            //mélange des cartes
            foreach (PictureBox image in conteneurGrandeCarte.Controls)
            {
                int next = localisationGrandeCarte.Next(coordonneesGrandeCarte.Count);
                Point p = coordonneesGrandeCarte[next];
                image.Location = p;
                coordonneesGrandeCarte.Remove(p);
            }

            //récupérer les localisations des emplacements
            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.Enabled = true;
                image.AllowDrop = false;
                image.Image = null;
                image.BorderStyle = BorderStyle.FixedSingle;
                image.DragDrop += new System.Windows.Forms.DragEventHandler(this.petiteImage_DragDrop);
                image.DragEnter += new System.Windows.Forms.DragEventHandler(this.petiteImage_DragEnter);
                coordonneesCarteAPlacer.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox

            }

            //mélange des cartes
            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                int next = localisationCarteAPlacer.Next(coordonneesCarteAPlacer.Count);
                Point p = coordonneesCarteAPlacer[next];
                image.Location = p;
                coordonneesCarteAPlacer.Remove(p);
            }

            //récupérer les localisations des petites cartes
            foreach (PictureBox image in conteneurPetiteCarte.Controls)
            {
                image.Enabled = true;
                image.Visible = true;
                image.Image = items.dosCarte;
                coordonneesPetiteCarte.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
                image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.receveurImage_MouseDown);
            }

            //mélange des cartes
            foreach (PictureBox image in conteneurPetiteCarte.Controls)
            {
                int next = localisationPetiteCarte.Next(coordonneesPetiteCarte.Count);
                Point p = coordonneesPetiteCarte[next];
                image.Location = p;
                coordonneesPetiteCarte.Remove(p);
            }
        }

        private void cliquerPremiereLigne(object sender, EventArgs e)
        {
            if (cartePetiteDejaSelectionnee == false)
            {
                PictureBox carteCourante = (PictureBox)sender;
                premiereCarteSelectionnee = (String)carteCourante.Tag;
                carteRetournee = true;
                int index = Int32.Parse((String)carteCourante.Tag) - 1;
                LectureCarteSon(index, carteCourante);
            }
        }

        private void petiteImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void petiteImage_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            image.Image = petiteImageRecup;
            destinationCarte = (String)image.Tag;
            DropCarte(image, finalScore);
        }

        private void receveurImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (carteRetournee == true)
            {
                PictureBox image = (PictureBox)sender;
                deuxiemeCarteSelectionnee = (String)image.Tag;
                cartePetiteDejaSelectionnee = true;
                int index = Int32.Parse((String)image.Tag) - 1;
                Console.WriteLine(index);
                LectureMouseDown(image, index);
                petiteImageRecup = image.Image;
                conteneurCarteAPlacer.DoDragDrop("x", DragDropEffects.Move);
            }
        }

        public void LectureCarteSon(int index, PictureBox pic)
        {
            pic.Image = img[index];
            JouerSon(sons[index]);

            foreach (PictureBox image in conteneurGrandeCarte.Controls)
            {
                if (image.Tag != pic.Tag & image.Enabled != false)
                {
                    image.Image = items.dosCarte;
                }
            }
        }

        public void DropCarte(PictureBox sender, int score)
        {
            if (premiereCarteSelectionnee.Equals(deuxiemeCarteSelectionnee) & premiereCarteSelectionnee.Equals(destinationCarte))
            {
                int index = Int32.Parse(premiereCarteSelectionnee) - 1;
                score++;
                cartePetiteDejaSelectionnee = false;
                carteRetournee = false;
                conteneurPetiteCarte.Controls[index].Hide();
                conteneurGrandeCarte.Controls[index].Enabled = false;
                JouerSon(items.applaudissement);
                sender.Enabled = false;
            }
            else
            {
                JouerSon(items.pouet);
                sender.Image = null;
            }

            if (this.score == score)
            {
                foreach (PictureBox imageGrande in conteneurGrandeCarte.Controls)
                {
                    imageGrande.Enabled = false;
                }

                MessageBox.Show("Tu as fini le 1er niveau !", "Bravo !");
                this.Enabled = false;
            }
        }

        public void LectureMouseDown(PictureBox pic, int index)
        {
            foreach (PictureBox petiteImage in conteneurPetiteCarte.Controls)
            {
                if (petiteImage.Tag != pic.Tag)
                {
                    petiteImage.Image = items.dosCarte;
                }
            }

            pic.Image = img[index];
            foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
            {
                petiteImage.AllowDrop = true;
            }

            //lecture du son lié à la petite carte
            JouerSon(sons[index+4]);

        }
    }
}
