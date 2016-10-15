using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grand_ou_petit_8
{
    public partial class GrandOuPetit8 : Form
    {
       
        public GrandOuPetit8()
        {
            InitializeComponent();
        }
        
    }

    public partial class GrandOuPetit8Panel : Panel 
   {
        private System.Windows.Forms.Panel conteneurPetiteCarte;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel conteneurCarteAPlacer;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel conteneurGrandeCarte;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox22;

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

        public GrandOuPetit8Panel()
        {
            initialize();
            chargementPartie();
        }

        private void chargementPartie()
        {
            this.Enabled = true;
            Score.Text = "0"; //initialisation du score à zéro
            carteRetournee = false;
            cartePetiteDejaSelectionnee = false;
            premiereCarteSelectionnee = "";
            deuxiemeCarteSelectionnee = "";
            destinationCarte = "";
            petiteImageRecup = null;

            //récupérer les localisations des grandes cartes
            foreach (PictureBox image in conteneurGrandeCarte.Controls)
            {
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

            //récupérer les localisations des emplacements de cartes
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

            //le dos des cartes est affiché
            foreach (PictureBox image in conteneurGrandeCarte.Controls)
            {
                image.Image = Properties.Resources.dosCarte;
            }

            foreach (PictureBox image in conteneurPetiteCarte.Controls)
            {
                image.Image = Properties.Resources.dosCarte;
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
                    carteCourante.Image = Properties.Resources.satoBuyuk;

                    foreach (PictureBox image in conteneurGrandeCarte.Controls)
                    {
                        if (image.Tag != carteCourante.Tag & image.Enabled != false)
                        {
                            image.Image = Properties.Resources.dosCarte;
                        }
                    }

                    //lecture du son lié à la carte
                    System.IO.Stream satoBuyukSon = Properties.Resources.satoBuyukSon;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(satoBuyukSon);
                    son.Play();
                }
                else if ((String)carteCourante.Tag == "2")
                {
                    carteCourante.Image = Properties.Resources.boiteGrande;

                    foreach (PictureBox image in conteneurGrandeCarte.Controls)
                    {
                        if (image.Tag != carteCourante.Tag & image.Enabled != false)
                        {
                            image.Image = Properties.Resources.dosCarte;
                        }
                    }

                    //lecture du son lié à la carte
                    System.IO.Stream boiteGrandeSon = Properties.Resources.boiteGrandeSon;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(boiteGrandeSon);
                    son.Play();
                }
                else if ((String)carteCourante.Tag == "3")
                {
                    carteCourante.Image = Properties.Resources.bahceBuyuk;

                    foreach (PictureBox image in conteneurGrandeCarte.Controls)
                    {
                        if (image.Tag != carteCourante.Tag & image.Enabled != false)
                        {
                            image.Image = Properties.Resources.dosCarte;
                        }
                    }

                    //lecture du son lié à la carte
                    System.IO.Stream bahceBuyukSon = Properties.Resources.bahceBuyukSon;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(bahceBuyukSon);
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
                    System.IO.Stream pontGrandSon = Properties.Resources.pontGrandSon;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(pontGrandSon);
                    son.Play();
                }
                else if ((String)carteCourante.Tag == "5")
                {
                    carteCourante.Image = Properties.Resources.yatakBuyuk;

                    foreach (PictureBox image in conteneurGrandeCarte.Controls)
                    {
                        if (image.Tag != carteCourante.Tag & image.Enabled != false)
                        {
                            image.Image = Properties.Resources.dosCarte;
                        }
                    }
                    //lecture du son lié à la carte
                    System.IO.Stream yatakBuyukSon = Properties.Resources.yatakBuyukSon;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(yatakBuyukSon);
                    son.Play();
                }
                else if ((String)carteCourante.Tag == "6")
                {
                    carteCourante.Image = Properties.Resources.masaBuyuk;

                    foreach (PictureBox image in conteneurGrandeCarte.Controls)
                    {
                        if (image.Tag != carteCourante.Tag & image.Enabled != false)
                        {
                            image.Image = Properties.Resources.dosCarte;
                        }
                    }
                    //lecture du son lié à la carte
                    System.IO.Stream masaBuyukSon = Properties.Resources.masaBuyukSon;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(masaBuyukSon);
                    son.Play();
                }
                else if ((String)carteCourante.Tag == "7")
                {
                    carteCourante.Image = Properties.Resources.chaiseGrande;

                    foreach (PictureBox image in conteneurGrandeCarte.Controls)
                    {
                        if (image.Tag != carteCourante.Tag & image.Enabled != false)
                        {
                            image.Image = Properties.Resources.dosCarte;
                        }
                    }
                    //lecture du son lié à la carte
                    System.IO.Stream chaiseGrandeSon = Properties.Resources.chaiseGrandeSon;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(chaiseGrandeSon);
                    son.Play();
                }
                else if ((String)carteCourante.Tag == "8")
                {
                    carteCourante.Image = Properties.Resources.foretGrande;

                    foreach (PictureBox image in conteneurGrandeCarte.Controls)
                    {
                        if (image.Tag != carteCourante.Tag & image.Enabled != false)
                        {
                            image.Image = Properties.Resources.dosCarte;
                        }
                    }
                    //lecture du son lié à la carte
                    System.IO.Stream foretGrandeSon = Properties.Resources.foretGrandeSon;
                    System.Media.SoundPlayer son = new System.Media.SoundPlayer(foretGrandeSon);
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
                MessageBox.Show("Bien joué !", "Bravo !!");

                if (premiereCarteSelectionnee == "1")
                {
                    foreach (PictureBox imagePetite in conteneurPetiteCarte.Controls)
                    {
                        if ((String)imagePetite.Tag == "1")
                        {
                            imagePetite.Hide();
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
                    foreach (PictureBox imagePetite in conteneurPetiteCarte.Controls)
                    {
                        if ((String)imagePetite.Tag == "2")
                        {
                            imagePetite.Hide();
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
                    foreach (PictureBox imagePetite in conteneurPetiteCarte.Controls)
                    {
                        if ((String)imagePetite.Tag == "3")
                        {
                            imagePetite.Hide();
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
                    foreach (PictureBox imagePetite in conteneurPetiteCarte.Controls)
                    {
                        if ((String)imagePetite.Tag == "4")
                        {
                            imagePetite.Hide();
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
                else if (premiereCarteSelectionnee == "5")
                {
                    foreach (PictureBox imagePetite in conteneurPetiteCarte.Controls)
                    {
                        if ((String)imagePetite.Tag == "5")
                        {
                            imagePetite.Hide();
                        }
                    }

                    foreach (PictureBox imageGrande in conteneurGrandeCarte.Controls)
                    {
                        if ((String)imageGrande.Tag == "5")
                        {
                            imageGrande.Enabled = false;
                        }
                    }

                    image.Enabled = false;
                }
                else if (premiereCarteSelectionnee == "6")
                {
                    foreach (PictureBox imagePetite in conteneurPetiteCarte.Controls)
                    {
                        if ((String)imagePetite.Tag == "6")
                        {
                            imagePetite.Hide();
                        }
                    }

                    foreach (PictureBox imageGrande in conteneurGrandeCarte.Controls)
                    {
                        if ((String)imageGrande.Tag == "6")
                        {
                            imageGrande.Enabled = false;
                        }
                    }

                    image.Enabled = false;
                }
                else if (premiereCarteSelectionnee == "7")
                {
                    foreach (PictureBox imagePetite in conteneurPetiteCarte.Controls)
                    {
                        if ((String)imagePetite.Tag == "7")
                        {
                            imagePetite.Hide();
                        }
                    }

                    foreach (PictureBox imageGrande in conteneurGrandeCarte.Controls)
                    {
                        if ((String)imageGrande.Tag == "7")
                        {
                            imageGrande.Enabled = false;
                        }
                    }

                    image.Enabled = false;
                }
                else if (premiereCarteSelectionnee == "8")
                {
                    foreach (PictureBox imagePetite in conteneurPetiteCarte.Controls)
                    {
                        if ((String)imagePetite.Tag == "8")
                        {
                            imagePetite.Hide();
                        }
                    }

                    foreach (PictureBox imageGrande in conteneurGrandeCarte.Controls)
                    {
                        if ((String)imageGrande.Tag == "8")
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

                MessageBox.Show("Ré-essayez !", "Dommage !");

                image.Image = null;
            }

            if (Score.Text == "8")
            {
                foreach (PictureBox imageGrande in conteneurGrandeCarte.Controls)
                {
                    imageGrande.Enabled = false;
                }

                MessageBox.Show("Tu as fini le 2ème niveau !", "Bravo !");
                this.Enabled = false;
                chargementPartie();
            }
        }

        private void receveurImage_MouseDown(object sender, MouseEventArgs e)
        {      
            if (carteRetournee == true)
            {
                PictureBox image = (PictureBox)sender;
                deuxiemeCarteSelectionnee = (String)image.Tag;
                cartePetiteDejaSelectionnee = true;

                if (carteRetournee == true)
                {
                    foreach (PictureBox petiteImage in conteneurPetiteCarte.Controls)
                    {
                        if (petiteImage.Tag != image.Tag)
                        {
                            petiteImage.Image = Properties.Resources.dosCarte;
                        }
                    }

                    if ((String)image.Tag == "1")
                    {
                        image.Image = Properties.Resources.satoKucuk;
                        foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
                        {
                            petiteImage.AllowDrop = true;
                        }

                        //lecture du son lié à la carte
                        System.IO.Stream satoKucukSon = Properties.Resources.satoKucukSon;
                        System.Media.SoundPlayer son = new System.Media.SoundPlayer(satoKucukSon);
                        son.Play();
                    }
                    else if ((String)image.Tag == "2")
                    {
                        image.Image = Properties.Resources.boitePetite;
                        foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
                        {
                            petiteImage.AllowDrop = true;
                        }

                        //lecture du son lié à la carte
                        System.IO.Stream boitePetiteSon = Properties.Resources.boitePetiteSon;
                        System.Media.SoundPlayer son = new System.Media.SoundPlayer(boitePetiteSon);
                        son.Play();
                    }
                    else if ((String)image.Tag == "3")
                    {
                        image.Image = Properties.Resources.bahceKucuk;
                        foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
                        {
                            petiteImage.AllowDrop = true;
                        }

                        //lecture du son lié à la carte
                        System.IO.Stream bahceKucukSon = Properties.Resources.bahceKucukSon;
                        System.Media.SoundPlayer son = new System.Media.SoundPlayer(bahceKucukSon);
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
                        System.IO.Stream pontPetitSon = Properties.Resources.pontPetitSon;
                        System.Media.SoundPlayer son = new System.Media.SoundPlayer(pontPetitSon);
                        son.Play();
                    }
                    else if ((String)image.Tag == "5")
                    {
                        image.Image = Properties.Resources.yatakKucuk;
                        foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
                        {
                            petiteImage.AllowDrop = true;
                        }

                        //lecture du son lié à la carte
                        System.IO.Stream yatakKucukSon = Properties.Resources.yatakKucukSon;
                        System.Media.SoundPlayer son = new System.Media.SoundPlayer(yatakKucukSon);
                        son.Play();
                    }
                    else if ((String)image.Tag == "6")
                    {
                        image.Image = Properties.Resources.masaKucuk;
                        foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
                        {
                            petiteImage.AllowDrop = true;
                        }

                        //lecture du son lié à la carte
                        System.IO.Stream masaKucukSon = Properties.Resources.masaKucukSon;
                        System.Media.SoundPlayer son = new System.Media.SoundPlayer(masaKucukSon);
                        son.Play();
                    }
                    else if ((String)image.Tag == "7")
                    {
                        image.Image = Properties.Resources.chaisePetite;
                        foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
                        {
                            petiteImage.AllowDrop = true;
                        }

                        //lecture du son lié à la carte
                        System.IO.Stream chaisePetiteSon = Properties.Resources.chaisePetiteSon;
                        System.Media.SoundPlayer son = new System.Media.SoundPlayer(chaisePetiteSon);
                        son.Play();
                    }
                    else if ((String)image.Tag == "8")
                    {
                        image.Image = Properties.Resources.foretPetite;
                        foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
                        {
                            petiteImage.AllowDrop = true;
                        }

                        //lecture du son lié à la carte
                        System.IO.Stream foretPetiteSon = Properties.Resources.foretPetiteSon;
                        System.Media.SoundPlayer son = new System.Media.SoundPlayer(foretPetiteSon);
                        son.Play();
                    }
                    petiteImageRecup = image.Image;
                    conteneurCarteAPlacer.DoDragDrop("x", DragDropEffects.Move);
                }
            }
        }
        
    }
 }
