using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ressources;

namespace Que_fait_le_Roi
{
    public class QueFaitLeRoiClass : Jeu.Jeu
    {
        public int finalScore;
        public int score;
        public Panel conteneurCarte;
        public Panel conteneurBouton;
        public Panel conteneurCarteAPlacer;
        public Random localisationBouton = new Random();
        public Random localisationCarte = new Random();
        public Random localisationCarteAPlacer = new Random();
        public List<Point> coordonneesCarte = new List<Point>();
        public List<Point> coordonneesBouton = new List<Point>();
        public List<Point> coordonneesCarteAPlacer = new List<Point>();
        public Image imageRecuperee;
        public String sonTag;
        public String carteTag;
        public String receveurTag;
        public Boolean sonBoutonEcoute;
        public List<Stream> sons = new List<Stream>();


        public QueFaitLeRoiClass ()
        {

        }

        public new void chargementPartie()
        {
            this.Enabled = true;
            carteTag = "";
            sonTag = "";
            receveurTag = "";
            sonBoutonEcoute = false;
            imageRecuperee = null;
            int indexEmplacement = 0;
            //on prepare les boutons
            foreach (Button bouton in conteneurBouton.Controls)
            {
                bouton.Enabled = true;
                coordonneesBouton.Add(bouton.Location);
            }
            
            //on prepare les emplacements 

            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.BorderStyle = BorderStyle.FixedSingle;
                image.AllowDrop = false;
                image.Image = null;
                image.Enabled = true;
                coordonneesCarteAPlacer.Add(image.Location);
            }

            //on repere la localisation des boutons et des emplacements
            foreach (Button bouton in conteneurBouton.Controls)
            {
                int next = localisationBouton.Next(coordonneesBouton.Count);
                Point p = coordonneesBouton[next];
                Point pEmplacement = coordonneesCarteAPlacer[next];
                bouton.Location = p;
                conteneurCarteAPlacer.Controls[indexEmplacement].Location = pEmplacement;
                coordonneesBouton.Remove(p);
                coordonneesCarteAPlacer.Remove(pEmplacement);
                indexEmplacement++;
            }
            
            //on prepare les carte a placer
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Visible = true;
                image.Enabled = true;
                image.SizeMode = PictureBoxSizeMode.StretchImage;

                coordonneesCarte.Add(image.Location);
            }

            //on repere la localisation des cartes
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                int next = localisationCarte.Next(coordonneesCarte.Count);
                Point p = coordonneesCarte[next];
                image.Location = p;
                coordonneesCarte.Remove(p);
            }
            
        }
        
        public void Ecouter(object sender, EventArgs e)
        {
            int index;
            Button bouton = (Button)sender;
            sonTag = (String)bouton.Tag;
            sonBoutonEcoute = true;
            index = Int32.Parse((String)bouton.Tag) - 1;

            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.AllowDrop = true;
            }

            JouerSon(sons[index]);
        }

        public void Image_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        public void Image_DragDrop(object sender, DragEventArgs e)
        {
            int index = Int32.Parse(sonTag) - 1;
            PictureBox image = (PictureBox)sender;

            receveurTag = (String)image.Tag;

            if (carteTag == sonTag & receveurTag == sonTag)
            {
                image.Image = imageRecuperee;
                sonBoutonEcoute = false;
                JouerSon(items.applaudissement);
                conteneurCarte.Controls[index].Hide();
                image.Enabled = false;
                this.score++;
            }
            else
            {
                JouerSon(items.pouet);
                image.Image = null;
            }

            if (this.score == finalScore)
            {
                foreach (PictureBox imageCarte in conteneurCarte.Controls)
                {
                    imageCarte.Enabled = false;
                }

                foreach (Button bouton in conteneurBouton.Controls)
                {
                    bouton.Enabled = false;
                }

                this.Enabled = false;
                chargementPartie();
            }

        }

        public void receveurImage_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            imageRecuperee = image.Image;
            carteTag = (String)image.Tag;
            int index = Int32.Parse(carteTag) + finalScore - 1;

            if (sonBoutonEcoute == true)
            {
                JouerSon(sons[index]);
            }
            conteneurCarteAPlacer.DoDragDrop("x", DragDropEffects.All);
        }
    }
}
