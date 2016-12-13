﻿using System;
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
        public Random localisation = new Random();
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
        int index;
        int indexEmplacement = 0;

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

            //récupérer les localisations des emplacements
            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.Enabled = true;
                image.AllowDrop = false;
                image.Image = null;
                image.BorderStyle = BorderStyle.FixedSingle;
                image.DragDrop += new DragEventHandler(this.petiteImage_DragDrop);
                image.DragEnter += new DragEventHandler(this.petiteImage_DragEnter);
                coordonneesCarteAPlacer.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox

            }

            //mélange des grandes cartes et des emplacements respectifs
            foreach (PictureBox image in conteneurGrandeCarte.Controls)
            {
                int next = localisation.Next(coordonneesGrandeCarte.Count);
                Point p = coordonneesGrandeCarte[next];
                Point pEmplacement = coordonneesCarteAPlacer[next];
                image.Location = p;
                conteneurCarteAPlacer.Controls[indexEmplacement].Location = pEmplacement;
                coordonneesGrandeCarte.Remove(p);
                coordonneesCarteAPlacer.Remove(conteneurCarteAPlacer.Controls[indexEmplacement].Location);
                indexEmplacement++;
            }
            

            //récupérer les localisations des petites cartes
            foreach (PictureBox image in conteneurPetiteCarte.Controls)
            {
                image.Enabled = true;
                image.Visible = true;
                image.Image = items.dosCarte;
                coordonneesPetiteCarte.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
                image.MouseDown += new MouseEventHandler(this.receveurImage_MouseDown);
            }

            //mélange des cartes
            foreach (PictureBox image in conteneurPetiteCarte.Controls)
            {
                int next = localisation.Next(coordonneesPetiteCarte.Count);
                Point p = coordonneesPetiteCarte[next];
                image.Location = p;
                coordonneesPetiteCarte.Remove(p);
            }
        }

        private void cliquerPremiereLigne(object sender, EventArgs e)
        {
            if (cartePetiteDejaSelectionnee == false)
            {
                //on retient la carte cliquee dans la premiere rangee
                PictureBox carteCourante = (PictureBox)sender;
                premiereCarteSelectionnee = (String)carteCourante.Tag;
                carteRetournee = true;
                index = Int32.Parse(premiereCarteSelectionnee) - 1;

                Console.WriteLine("premiere carte : " + index);
                //on devoile la carte
                carteCourante.Image = img[index];

                //on ecoute le son associe a la carte
                JouerSon(sons[index]);

                //les autres cartes doivent etre retournees
                foreach (PictureBox image in conteneurGrandeCarte.Controls)
                {
                    if (image.Tag != carteCourante.Tag & image.Enabled != false)
                    {
                        image.Image = items.dosCarte;
                    }
                }
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

            Console.WriteLine(premiereCarteSelectionnee);
            Console.WriteLine(deuxiemeCarteSelectionnee);
            Console.WriteLine(destinationCarte);
            if (premiereCarteSelectionnee.Equals(deuxiemeCarteSelectionnee) & premiereCarteSelectionnee.Equals(destinationCarte))
            {
                this.score++;
                cartePetiteDejaSelectionnee = false;
                carteRetournee = false;
                Console.WriteLine("petite carte a retirer:" + index);
                conteneurPetiteCarte.Controls[index].Hide();
                conteneurGrandeCarte.Controls[index].Enabled = false;
                JouerSon(items.applaudissement);
                image.Enabled = false;
            }
            else
            {
                JouerSon(items.pouet);
                image.Image = null;
            }

            if (this.score == finalScore)
            {
                foreach (PictureBox imageGrande in conteneurGrandeCarte.Controls)
                {
                    imageGrande.Enabled = false;
                }

                MessageBox.Show("Tu as fini le 1er niveau !", "Bravo !");
                this.Enabled = false;
            }
        }

        private void receveurImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (carteRetournee == true)
            {
                //on recupere les donnees de la petite carte
                PictureBox image = (PictureBox)sender;
                deuxiemeCarteSelectionnee = (String)image.Tag;
                cartePetiteDejaSelectionnee = true;
                int index = Int32.Parse(deuxiemeCarteSelectionnee) - 1;
                Console.WriteLine("tag de la petite carte: " + index);

                //on retourne toutes les cartes
                foreach (PictureBox petiteImage in conteneurPetiteCarte.Controls)
                {
                    if (petiteImage.Tag != image.Tag)
                    {
                        petiteImage.Image = items.dosCarte;
                    }
                }

                image.Image = img[index];
                foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
                {
                    petiteImage.AllowDrop = true;
                }

                //lecture du son lié à la petite carte
                JouerSon(sons[index + finalScore]);

                petiteImageRecup = image.Image;
                conteneurCarteAPlacer.DoDragDrop("x", DragDropEffects.Move);
            }
        }
        
    }
}