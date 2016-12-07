using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jeu;

namespace Grand_ou_Petit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    public partial class GrandOuPetit : Jeu.Jeu
    {
        private System.Windows.Forms.Panel conteneurGrandeCarte;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Panel conteneurCarteAPlacer;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel conteneurPetiteCarte;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;

        Random localisationGrandeCarte = new Random();
        Random localisationCarteAPlacer = new Random();
        Random localisationPetiteCarte = new Random();
        List<Point> coordonneesGrandeCarte = new List<Point>(); //liste des localisations des PictureBox
        List<Point> coordonneesCarteAPlacer = new List<Point>(); //liste des localisations des PictureBox
        List<Point> coordonneesPetiteCarte = new List<Point>(); //liste des localisations des PictureBox

        Image petiteImageRecup;
        Boolean carteRetournee;
        Boolean cartePetiteDejaSelectionnee;
        String premiereCarteSelectionnee;
        String deuxiemeCarteSelectionnee;
        String destinationCarte;

        public GrandOuPetit()
        {
            initialize();
            chargementPartie();
        }

        private new void chargementPartie()
        {
            this.Enabled = true;
            Score.Text = "0"; //initialisation du score à zéro
            Score.Visible = false;
            label.Visible = false;
            carteRetournee = false;
            cartePetiteDejaSelectionnee = false;
            premiereCarteSelectionnee = "";
            deuxiemeCarteSelectionnee = "";
            destinationCarte = "";
            petiteImageRecup = null;

            //récupérer les localisations des grandes cartes
            foreach (PictureBox image in conteneurGrandeCarte.Controls)
            {
                image.Image = Properties.Resources.dosCarte;
                image.Enabled = true;
                coordonneesGrandeCarte.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
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
                image.Image = Properties.Resources.dosCarte;
                coordonneesPetiteCarte.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
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

                //attribution des mots pour chaque paires selon le tag 
                if ((String)carteCourante.Tag == "1")
                {
                    carteCourante.Image = Properties.Resources.chateauGrand;

                    foreach (PictureBox image in conteneurGrandeCarte.Controls)
                    {
                        if (image.Tag != carteCourante.Tag & image.Enabled != false)
                        {
                            image.Image = Properties.Resources.dosCarte;
                        }
                    }

                    //lecture du son lié à la carte
                    System.IO.Stream grandChateau = Properties.Resources.grandChateau;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(grandChateau);
                    son.Play();
                }
                else if ((String)carteCourante.Tag == "2")
                {
                    carteCourante.Image = Properties.Resources.coffreGrand;

                    foreach (PictureBox image in conteneurGrandeCarte.Controls)
                    {
                        if (image.Tag != carteCourante.Tag & image.Enabled != false)
                        {
                            image.Image = Properties.Resources.dosCarte;
                        }
                    }

                    //lecture du son lié à la carte
                    System.IO.Stream grandeBoite = Properties.Resources.grandeBoite;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(grandeBoite);
                    son.Play();
                }
                else if ((String)carteCourante.Tag == "3")
                {
                    carteCourante.Image = Properties.Resources.jardinGrand;

                    foreach (PictureBox image in conteneurGrandeCarte.Controls)
                    {
                        if (image.Tag != carteCourante.Tag & image.Enabled != false)
                        {
                            image.Image = Properties.Resources.dosCarte;
                        }
                    }

                    //lecture du son lié à la carte
                    System.IO.Stream buyukBahce = Properties.Resources.buyukBahce;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(buyukBahce);
                    son.Play();
                }
                else if ((String)carteCourante.Tag == "4")
                {
                    carteCourante.Image = Properties.Resources.pontGrand;

                    foreach (PictureBox image in conteneurGrandeCarte.Controls)
                    {
                        if (image.Tag != carteCourante.Tag & image.Enabled != false)
                        {
                            image.Image = Properties.Resources.dosCarte;
                        }
                    }
                    //lecture du son lié à la carte
                    System.IO.Stream buyukKopru = Properties.Resources.buyukKopru;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(buyukKopru);
                    son.Play();
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

            if (premiereCarteSelectionnee == deuxiemeCarteSelectionnee & premiereCarteSelectionnee == destinationCarte)
            {
                Score.Text = Convert.ToString(Convert.ToInt32(Score.Text) + 1);
                cartePetiteDejaSelectionnee = false;
                carteRetournee = false;

                System.IO.Stream applaudissement = Properties.Resources.applaudissement;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(applaudissement);
                son.Play();

                if (premiereCarteSelectionnee == "1")
                {
                    foreach (PictureBox imageGrande in conteneurPetiteCarte.Controls)
                    {
                        if ((String)imageGrande.Tag == "1")
                        {
                            imageGrande.Hide();
                        }
                    }

                    foreach (PictureBox imageGrande in conteneurGrandeCarte.Controls)
                    {
                        if ((String)imageGrande.Tag == "1")
                        {
                            imageGrande.Enabled = false;
                        }
                    }

                    image.Enabled = false;
                }
                else if (premiereCarteSelectionnee == "2")
                {
                    foreach (PictureBox imageGrande in conteneurPetiteCarte.Controls)
                    {
                        if ((String)imageGrande.Tag == "2")
                        {
                            imageGrande.Hide();
                        }
                    }

                    foreach (PictureBox imageGrande in conteneurGrandeCarte.Controls)
                    {
                        if ((String)imageGrande.Tag == "2")
                        {
                            imageGrande.Enabled = false;
                        }
                    }

                    image.Enabled = false;
                }
                else if (premiereCarteSelectionnee == "3")
                {
                    foreach (PictureBox imageGrande in conteneurPetiteCarte.Controls)
                    {
                        if ((String)imageGrande.Tag == "3")
                        {
                            imageGrande.Hide();
                        }
                    }

                    foreach (PictureBox imageGrande in conteneurGrandeCarte.Controls)
                    {
                        if ((String)imageGrande.Tag == "3")
                        {
                            imageGrande.Enabled = false;
                        }
                    }

                    image.Enabled = false;
                }
                else if (premiereCarteSelectionnee == "4")
                {
                    foreach (PictureBox imageGrande in conteneurPetiteCarte.Controls)
                    {
                        if ((String)imageGrande.Tag == "4")
                        {
                            imageGrande.Hide();
                        }
                    }

                    foreach (PictureBox imageGrande in conteneurGrandeCarte.Controls)
                    {
                        if ((String)imageGrande.Tag == "4")
                        {
                            imageGrande.Enabled = false;
                        }
                    }

                    image.Enabled = false;
                }
            }
            else
            {
                System.IO.Stream pouet = Properties.Resources.pouet;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(pouet);
                son.Play();

                image.Image = null;
            }

            if (Score.Text == "4")
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
                PictureBox image = (PictureBox)sender;
                deuxiemeCarteSelectionnee = (String)image.Tag;
                cartePetiteDejaSelectionnee = true;

                foreach (PictureBox petiteImage in conteneurPetiteCarte.Controls)
                {
                    if (petiteImage.Tag != image.Tag)
                    {
                        petiteImage.Image = Properties.Resources.dosCarte;
                    }
                }

                if ((String)image.Tag == "1")
                {
                    image.Image = Properties.Resources.chateauPetit;
                    foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
                    {
                        petiteImage.AllowDrop = true;
                    }

                    //lecture du son lié à la carte
                    System.IO.Stream petitChateau = Properties.Resources.petitChateau;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(petitChateau);
                    son.Play();
                }
                else if ((String)image.Tag == "2")
                {
                    image.Image = Properties.Resources.coffrePetit;
                    foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
                    {
                        petiteImage.AllowDrop = true;
                    }

                    //lecture du son lié à la carte
                    System.IO.Stream petiteBoite = Properties.Resources.petiteBoite;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(petiteBoite);
                    son.Play();
                }
                else if ((String)image.Tag == "3")
                {
                    image.Image = Properties.Resources.jardinPetit;
                    foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
                    {
                        petiteImage.AllowDrop = true;
                    }

                    //lecture du son lié à la carte
                    System.IO.Stream kucukBahce = Properties.Resources.kucukBahce;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(kucukBahce);
                    son.Play();
                }
                else if ((String)image.Tag == "4")
                {
                    image.Image = Properties.Resources.pontPetit;
                    foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
                    {
                        petiteImage.AllowDrop = true;
                    }

                    //lecture du son lié à la carte
                    System.IO.Stream kucukKopru = Properties.Resources.kucukKopru;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(kucukKopru);
                    son.Play();
                }

                petiteImageRecup = image.Image;
                conteneurCarteAPlacer.DoDragDrop("x", DragDropEffects.Move);
            }
        }
        
    }
}
