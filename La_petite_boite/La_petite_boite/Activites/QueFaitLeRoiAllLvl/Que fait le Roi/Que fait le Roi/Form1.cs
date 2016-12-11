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
using Ressources;

namespace Que_fait_le_Roi
{
    public partial class QueFaitLeRoi : Form
    {
        public QueFaitLeRoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //QuefaitleRoi4
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new QueFaitLeRoi4Panel());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //QuefaitleRoi8
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new QueFaitLeRoi8Panel());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //QuefaitleRoi12
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            //this.Controls.Add(new QueFaitLeRoi4Panel());
        }
    }

    public partial class QueFaitLeRoi4Panel : QueFaitLeRoiClass
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        

        public QueFaitLeRoi4Panel()
        {
            initialize();
            chargementPartie();

            button1.Tag = "1";
            button1.Text = "Le roi rentre au château.";
            button2.Tag = "2";
            button2.Text = "Kral okula girer.";
            button3.Tag = "3";
            button3.Text = "Le roi traverse la forêt.";
            button4.Tag = "4";
            button4.Text = "Kral bahceyi gecer.";

            //sons pour les boutons
            sons.Add(items.roiRentreAuChateauFR); //0
            sons.Add(items.roiVaALecoleTurc); //1
            sons.Add(items.roiTraverseLaForetFR); //2
            sons.Add(items.roiTraverseLeJardinTurc); //3

            //sons pour les images
            sons.Add(items.chateauFR); //4
            sons.Add(items.ecoleTurc); //5
            sons.Add(items.foretFR); //6
            sons.Add(items.jardinTurc); //7

            //picturebox

            img.Add(pictureBox1);
            img.Add(pictureBox2);
            img.Add(pictureBox3);
            img.Add(pictureBox4);
            this.pictureBox1.Image = items.chateau1;
            this.pictureBox2.Image = items.ecole1;
            this.pictureBox3.Image = items.foret1;
            this.pictureBox4.Image = items.jardin1;
        }
        
        public void Ecouter(object sender, EventArgs e)
        {
            int index;
            Button bouton = (Button)sender;
            sonTag = (String)bouton.Tag;
            sonBoutonEcoute = true;
            index = Int32.Parse((String)bouton.Tag) - 1;
            EcouterQueFaitLeRoi(sons[index]);
        }

        public void Image_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        public void Image_DragDrop(object sender, DragEventArgs e)
        {
            int index = Int32.Parse(sonTag) - 1;
            PictureBox image = (PictureBox)sender;
            DragDropQueFaitLeRoi(image, img[index], 4);
            
        }

        private void receveurImage_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            imageRecuperee = image.Image;
            carteTag = (String)image.Tag;
            int index = Int32.Parse(carteTag) + 3;
            MouseDownQueFaitLeRoi(index);
            conteneurCarteAPlacer.DoDragDrop("x", DragDropEffects.All);
        }
    }

    public partial class QueFaitLeRoi8Panel : QueFaitLeRoiClass
    {
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        

        public QueFaitLeRoi8Panel()
        {
            initialize();
            chargementPartie();

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

            //sons pour les boutons
            sons.Add(items.roiRentreAuChateauTurc);
            sons.Add(items.roiVaALecoleFR);
            sons.Add(items.roiTraverseLaForetTurc); 
            sons.Add(items.roiTraverseLeJardinFR); 
            sons.Add(items.roiMonteEscalierTurc); 
            sons.Add(items.roiGrimpeLitFR); 
            sons.Add(items.roiMonteChaiseTurc); 
            sons.Add(items.questionBoite); 

            //sons pour les images
            sons.Add(items.chateauTurc); 
            sons.Add(items.ecoleFR); 
            sons.Add(items.foretTurc); 
            sons.Add(items.jardinFR); 
            sons.Add(items.escalierTurc); 
            sons.Add(items.litFR); 
            sons.Add(items.chaiseTurc); 
            sons.Add(items.coffreFR); 

            //picturebox

            img.Add(pictureBox16);
            img.Add(pictureBox14);
            img.Add(pictureBox13);
            img.Add(pictureBox12);
            img.Add(pictureBox4);
            img.Add(pictureBox1);
            img.Add(pictureBox2);
            img.Add(pictureBox3);
            this.pictureBox1.Image = items.chateau1;
            this.pictureBox2.Image = items.ecole1;
            this.pictureBox3.Image = items.foret1;
            this.pictureBox4.Image = items.jardin1;
            this.pictureBox12.Image = items.escalier1;
            this.pictureBox13.Image = items.lit1;
            this.pictureBox14.Image = items.chaise1;
            this.pictureBox16.Image = items.coffre1;
        }
        
        private void Ecouter(object sender, EventArgs e)
        {
            int index;
            Button bouton = (Button)sender;
            sonTag = (String)bouton.Tag;
            sonBoutonEcoute = true;
            index = Int32.Parse((String)bouton.Tag) - 1;
            EcouterQueFaitLeRoi(sons[index]);
        }

        private void Image_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Image_DragDrop(object sender, DragEventArgs e)
        {
            int index = Int32.Parse(sonTag) - 1;
            PictureBox image = (PictureBox)sender;
            DragDropQueFaitLeRoi(image, img[index], 8);
            
        }

        private void receveurImage_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            imageRecuperee = image.Image;
            carteTag = (String)image.Tag;
            int index = Int32.Parse(carteTag) + 3;
            MouseDownQueFaitLeRoi(index);
            conteneurCarteAPlacer.DoDragDrop("x", DragDropEffects.All);
        }

    }

   /* public partial class QueFaitLeRoi12Panel : Jeu.Jeu
    {
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel conteneurCarteAPlacer;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel conteneurCarte;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.Panel conteneurBouton;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

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

        public QueFaitLeRoi12Panel()
        {
            initialize();
            chargementPartie();
        }

        private new void chargementPartie()
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
            button1.Text = "Le roi rentre au château.";
            button2.Tag = "2";
            button2.Text = "Kral okula girer.";
            button3.Tag = "3";
            button3.Text = "Le roi traverse la forêt.";
            button4.Tag = "4";
            button4.Text = "Kral bahceyi gecer.";
            button5.Tag = "5";
            button5.Text = "Le roi monte l'escalier.";
            button6.Tag = "6";
            button6.Text = "Kral yataga cikar.";
            button7.Tag = "7";
            button7.Text = "Le roi grimpe sur la chaise.";
            button8.Tag = "8";
            button8.Text = "Bu kutuda ne var ?";
            button9.Tag = "9";
            button9.Text = "Kral bir banyo alir.";
            button10.Tag = "10";
            button10.Text = "Le roi s'installe à table.";
            button11.Tag = "11";
            button11.Text = "Kral pijama giyer.";
            button12.Tag = "12";
            button12.Text = "Le roi fait une pause.";

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
                System.IO.Stream leRoiRentreAuChateauSon = Properties.Resources.leRoiRentreAuChateauSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(leRoiRentreAuChateauSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "2")
            {
                System.IO.Stream kralOkulaGirerSon = Properties.Resources.kralOkulaGirerSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(kralOkulaGirerSon);
                son.Play();

            }
            else if ((String)bouton.Tag == "3")
            {
                System.IO.Stream leRoiTraverseLaForetSon = Properties.Resources.leRoiTraverseLaForetSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(leRoiTraverseLaForetSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "4")
            {
                System.IO.Stream kralBahceyiGecerSon = Properties.Resources.kralBahceyiGecerSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(kralBahceyiGecerSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "5")
            {
                System.IO.Stream leRoiMonteLEscalierSon = Properties.Resources.leRoiMonteLEscalierSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(leRoiMonteLEscalierSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "6")
            {
                System.IO.Stream kralYatagaCikarSon = Properties.Resources.kralYatagaCikarSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(kralYatagaCikarSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "7")
            {
                System.IO.Stream leRoiGrimpeSurLaChaiseSon = Properties.Resources.leRoiGrimpeSurLaChaiseSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(leRoiGrimpeSurLaChaiseSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "8")
            {
                System.IO.Stream buKutudaNeVarSon = Properties.Resources.buKutudaNeVarSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(buKutudaNeVarSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "9")
            {
                System.IO.Stream kralBanyoAliyorSon = Properties.Resources.kralBirBanyoAlirSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(kralBanyoAliyorSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "10")
            {
                System.IO.Stream leRoiSInstalleATableSon = Properties.Resources.Le_Roi_S_installe_À_Table;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(leRoiSInstalleATableSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "11")
            {
                System.IO.Stream kralPijamaGiyerSon = Properties.Resources.kralPijamaGiyerSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(kralPijamaGiyerSon);
                son.Play();
            }
            else if ((String)bouton.Tag == "12")
            {
                System.IO.Stream leRoiFaitUnePauseSon = Properties.Resources.leRoiFaitUnePauseSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(leRoiFaitUnePauseSon);
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
                else if (sonTag == "9")
                {
                    foreach (PictureBox imageCarte in conteneurCarte.Controls)
                    {
                        if ((String)imageCarte.Tag == "9")
                        {
                            imageCarte.Hide();
                        }

                    }
                    image.Enabled = false;
                }
                else if (sonTag == "10")
                {
                    foreach (PictureBox imageCarte in conteneurCarte.Controls)
                    {
                        if ((String)imageCarte.Tag == "10")
                        {
                            imageCarte.Hide();
                        }

                    }
                    image.Enabled = false;
                }
                else if (sonTag == "11")
                {
                    foreach (PictureBox imageCarte in conteneurCarte.Controls)
                    {
                        if ((String)imageCarte.Tag == "11")
                        {
                            imageCarte.Hide();
                        }

                    }
                    image.Enabled = false;
                }
                else if (sonTag == "12")
                {
                    foreach (PictureBox imageCarte in conteneurCarte.Controls)
                    {
                        if ((String)imageCarte.Tag == "12")
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

            if (Score.Text == "12")
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

        private void receveurImage_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            imageRecuperee = image.Image;
            carteTag = (String)image.Tag;

            if (sonBoutonEcoute == true & (String)image.Tag == "1")
            {
                System.IO.Stream chateauSon = Properties.Resources.chateauSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(chateauSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "2")
            {
                System.IO.Stream okulSon = Properties.Resources.okulSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(okulSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "3")
            {
                System.IO.Stream foretSon = Properties.Resources.foretSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(foretSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "4")
            {
                System.IO.Stream bahceSon = Properties.Resources.bahceSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(bahceSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "5")
            {
                System.IO.Stream escalierSon = Properties.Resources.escalierSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(escalierSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "6")
            {
                System.IO.Stream yatakSon = Properties.Resources.yatakSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(yatakSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "7")
            {
                System.IO.Stream chaiseSon = Properties.Resources.chaiseSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(chaiseSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "8")
            {
                System.IO.Stream kutuSon = Properties.Resources.kutuSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(kutuSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "9")
            {
                System.IO.Stream banyoSon = Properties.Resources.banyoSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(banyoSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "10")
            {
                System.IO.Stream tableSon = Properties.Resources.tableSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(tableSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "11")
            {
                System.IO.Stream pijamaSon = Properties.Resources.pijamaSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(pijamaSon);
                son.Play();
            }
            else if (sonBoutonEcoute == true & (String)image.Tag == "12")
            {
                System.IO.Stream pauseSon = Properties.Resources.pauseSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(pauseSon);
                son.Play();
            }

            conteneurCarteAPlacer.DoDragDrop("x", DragDropEffects.All);
        }

    }*/
}
