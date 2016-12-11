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
        public List<PictureBox> img = new List<PictureBox>();


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

            //on prepare les emplacements 

            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.BorderStyle = BorderStyle.FixedSingle;
                image.AllowDrop = false;
                image.Image = null;
                image.Enabled = true;
                coordonneesCarteAPlacer.Add(image.Location);
            }

            //on repere les coordonnees de chaque carte
            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                int next = localisationCarteAPlacer.Next(coordonneesCarteAPlacer.Count);
                Point p = coordonneesCarteAPlacer[next];
                image.Location = p;
                coordonneesCarteAPlacer.Remove(p);
            }

            //on prepare les carte a placer
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Visible = true;
                image.Enabled = true;
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

            //on prepare les boutons
            foreach (Button bouton in conteneurBouton.Controls)
            {
                bouton.Enabled = true;
                coordonneesBouton.Add(bouton.Location);
            }

            //on repere la localisation des boutons
            foreach (Button bouton in conteneurBouton.Controls)
            {
                int next = localisationBouton.Next(coordonneesBouton.Count);
                Point p = coordonneesBouton[next];
                bouton.Location = p;
                coordonneesBouton.Remove(p);
            }
        }

        public void EcouterQueFaitLeRoi(Stream str)
        {
            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.AllowDrop = true;
            }

            JouerSon(str);
        }

        public void DragDropQueFaitLeRoi(PictureBox sender, PictureBox pic, int score)
        {
            receveurTag = (String)sender.Tag;

            if (carteTag == sonTag & receveurTag == sonTag)
            {
                sender.Image = imageRecuperee;
                sonBoutonEcoute = false;
                JouerSon(items.applaudissement);
                pic.Hide();
                sender.Enabled = false;
                score++;
            }
            else
            {
                JouerSon(items.pouet);
                sender.Image = null;
            }

            if (this.score == score)
            {
                foreach (PictureBox imageCarte in conteneurCarte.Controls)
                {
                    imageCarte.Enabled = false;
                }

                foreach (Button bouton in conteneurBouton.Controls)
                {
                    bouton.Enabled = false;
                }

                MessageBox.Show("Tu as fini le 1er niveau !", "Bravo !");
                this.Enabled = false;
            }
        }

        public void MouseDownQueFaitLeRoi(int nbr)
        {
            if (sonBoutonEcoute == true)
            {
                JouerSon(sons[nbr]);
            }
        }
    }
}
