using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Que_fait_le_roi_8
{
    public partial class queFaitLeRoi8 : Form
    {
       
        public queFaitLeRoi8()
        {
            InitializeComponent();
        }
        
    }

    public partial class QueFaitLeRoi8Panel : Panel
    {
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel conteneurBouton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel conteneurCarteAPlacer;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel conteneurCarte;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;

        Random localisationBouton = new Random();
        Random localisationCarte = new Random();
        Random localisationCarteAPlacer = new Random();
        List<Point> coordonneesCarte = new List<Point>();
        List<Point> coordonneesBouton = new List<Point>();
        List<Point> coordonneesCarteAPlacer = new List<Point>();

        Image imageRecuperee;
        String sonTag;
        String carteTag;
        String receveurTag;
        Boolean sonBoutonEcoute;

        public QueFaitLeRoi8Panel()
        {
            initialize();
            QueFaitLeRoi_Load();
        }

        private void QueFaitLeRoi_Load()
        {
            this.Enabled = true;
            Score.Visible = false;
            label1.Visible = false;
            Score.Text = "0";
            carteTag = "";
            sonTag = "";
            receveurTag = "";
            sonBoutonEcoute = false;
            imageRecuperee = null;

            button1.Tag = "1";
            button1.Text = "Kral şatoya girer.";
            button2.Tag = "2";
            button2.Text = "Le roi rentre à l'école.";
            button3.Tag = "3";
            button3.Text = "Kral ormani geçer.";
            button4.Tag = "4";
            button4.Text = "Le roi traverse le jardin.";
            button5.Tag = "5";
            button5.Text = "Kral merdivenleri cikar.";
            button6.Tag = "6";
            button6.Text = "Le roi grimpe sur le lit.";
            button7.Tag = "7";
            button7.Text = "Kral sandalyeye cikar.";
            button8.Tag = "8";
            button8.Text = "Qu'est-ce qu'il y a dans cette boite ?";

            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.BorderStyle = BorderStyle.FixedSingle;
                image.AllowDrop = false;
                image.Image = null;
                image.Enabled = true;
                coordonneesCarteAPlacer.Add(image.Location); 
            }

            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                int next = localisationCarteAPlacer.Next(coordonneesCarteAPlacer.Count);
                Point p = coordonneesCarteAPlacer[next];
                image.Location = p;
                coordonneesCarteAPlacer.Remove(p);
            }

            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Visible = true;
                image.Enabled = true;
                coordonneesCarte.Add(image.Location); 
            }

            foreach (PictureBox image in conteneurCarte.Controls)
            {
                int next = localisationCarte.Next(coordonneesCarte.Count);
                Point p = coordonneesCarte[next];
                image.Location = p;
                coordonneesCarte.Remove(p);
            }

            foreach (Button bouton in conteneurBouton.Controls)
            {
                bouton.Enabled = true;
                coordonneesBouton.Add(bouton.Location);
            }

            foreach (Button bouton in conteneurBouton.Controls)
            {
                int next = localisationBouton.Next(coordonneesBouton.Count);
                Point p = coordonneesBouton[next];
                bouton.Location = p;
                coordonneesBouton.Remove(p);
            }
        }
        

        private void Ecouter(object sender, EventArgs e)
        {
            Button bouton = (Button)sender;
            sonTag = (String)bouton.Tag;
            sonBoutonEcoute = true;

            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.AllowDrop = true;
            }

            if ((String)bouton.Tag == "1")
            {
                System.IO.Stream kralSatoyaGirerSon = Properties.Resources.kralSatoyaGirerSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(kralSatoyaGirerSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "2")
            {
                System.IO.Stream leRoiRentreALecoleSon = Properties.Resources.Le_Rentre_À_L_école;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(leRoiRentreALecoleSon);
                son.Play();

            }
            else if ((String)bouton.Tag == "3")
            {
                System.IO.Stream kralOrmaniGecerSon = Properties.Resources.kralOrmaniGecerSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(kralOrmaniGecerSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "4")
            {
                System.IO.Stream leRoiTraverseLeJardinSon = Properties.Resources.leRoiTraverseLeJardinSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(leRoiTraverseLeJardinSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "5")
            {
                System.IO.Stream kralMerdivenleriCikarSon = Properties.Resources.kralMerdivenleriCikarSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(kralMerdivenleriCikarSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "6")
            {
                System.IO.Stream leRoiGrimpeSurLeLitSon = Properties.Resources.leRoiGrimpeSurLeLitSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(leRoiGrimpeSurLeLitSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "7")
            {
                System.IO.Stream kralSandalyeyeCikarSon = Properties.Resources.kralSandalyeyeCikarSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(kralSandalyeyeCikarSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "8")
            {
                System.IO.Stream quEstCeQuIlyaDansCetteBoiteSon = Properties.Resources.quEstCeQuIlyaDansCetteBoiteSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(quEstCeQuIlyaDansCetteBoiteSon);
                son.Play();
            }
        }

        private void Image_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Image_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            receveurTag = (String)image.Tag;

            if (carteTag == sonTag & receveurTag == sonTag)
            {
                image.Image = imageRecuperee;
                Score.Text = Convert.ToString(Convert.ToInt32(Score.Text) + 1);
                sonBoutonEcoute = false;

                System.IO.Stream applaudissement = Properties.Resources.applaudissement;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(applaudissement);
                son.Play();

                if (sonTag == "1")
                {
                    foreach (PictureBox imageCarte in conteneurCarte.Controls)
                    {
                        if ((String)imageCarte.Tag == "1")
                        {
                            imageCarte.Hide();
                        }

                    }
                    image.Enabled = false;
                }
                else if (sonTag == "2")
                {
                    foreach (PictureBox imageCarte in conteneurCarte.Controls)
                    {
                        if ((String)imageCarte.Tag == "2")
                        {
                            imageCarte.Hide();
                        }

                    }
                    image.Enabled = false;
                }
                else if (sonTag == "3")
                {
                    foreach (PictureBox imageCarte in conteneurCarte.Controls)
                    {
                        if ((String)imageCarte.Tag == "3")
                        {
                            imageCarte.Hide();
                        }

                    }
                    image.Enabled = false;
                }
                else if (sonTag == "4")
                {
                    foreach (PictureBox imageCarte in conteneurCarte.Controls)
                    {
                        if ((String)imageCarte.Tag == "4")
                        {
                            imageCarte.Hide();
                        }

                    }
                    image.Enabled = false;
                }
                else if (sonTag == "5")
                {
                    foreach (PictureBox imageCarte in conteneurCarte.Controls)
                    {
                        if ((String)imageCarte.Tag == "5")
                        {
                            imageCarte.Hide();
                        }

                    }
                    image.Enabled = false;
                }
                else if (sonTag == "6")
                {
                    foreach (PictureBox imageCarte in conteneurCarte.Controls)
                    {
                        if ((String)imageCarte.Tag == "6")
                        {
                            imageCarte.Hide();
                        }

                    }
                    image.Enabled = false;
                }
                else if ((String)sonTag == "7")
                {
                    foreach (PictureBox imageCarte in conteneurCarte.Controls)
                    {
                        if ((String)imageCarte.Tag == "7")
                        {
                            imageCarte.Hide();
                        }

                    }
                    image.Enabled = false;
                }
                else if (sonTag == "8")
                {
                    foreach (PictureBox imageCarte in conteneurCarte.Controls)
                    {
                        if ((String)imageCarte.Tag == "8")
                        {
                            imageCarte.Hide();
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

            if (Score.Text == "8")
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
                QueFaitLeRoi_Load();
                
            }
        }

        private void receveurImage_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            imageRecuperee = image.Image;
            carteTag = (String)image.Tag;

            if (sonBoutonEcoute == true & (String)image.Tag == "1")
            {
                System.IO.Stream satoSon = Properties.Resources.satoSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(satoSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "2")
            {
                System.IO.Stream ecoleSon = Properties.Resources.ecoleSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(ecoleSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "3")
            {
                System.IO.Stream ormanSon = Properties.Resources.ormanSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(ormanSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "4")
            {
                System.IO.Stream jardinSon = Properties.Resources.jardinSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(jardinSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "5")
            {
                System.IO.Stream merdivenSon = Properties.Resources.merdivenSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(merdivenSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "6")
            {
                System.IO.Stream litSon = Properties.Resources.litSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(litSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "7")
            {
                System.IO.Stream sandalyeSon = Properties.Resources.sandalyeSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(sandalyeSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "8")
            {
                System.IO.Stream boiteSon = Properties.Resources.boiteSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(boiteSon);
                son.Play();
            }

            conteneurCarteAPlacer.DoDragDrop("x", DragDropEffects.All);
        }
  
    }
 }
