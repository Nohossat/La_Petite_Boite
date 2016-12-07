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

namespace chasseAuxMots12Cartes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    public partial class ChasseAuxMots12Panel : Jeu.Jeu
    {
        Random localisation = new Random(); //
        List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox
        String carteACliquerTag;
        String imageCliqueTag;
        int demarrage;
        Boolean son1DejaTrouve;
        Boolean son2DejaTrouve;
        Boolean son3DejaTrouve;
        Boolean son4DejaTrouve;
        Boolean son5DejaTrouve;
        Boolean son6DejaTrouve;
        Boolean son7DejaTrouve;
        Boolean son8DejaTrouve;
        Boolean son9DejaTrouve;
        Boolean son10DejaTrouve;
        Boolean son11DejaTrouve;
        Boolean son12DejaTrouve;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Resultat;
        private System.Windows.Forms.Button Ecouter;
        private System.Windows.Forms.Panel conteneurCarte;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;

        public ChasseAuxMots12Panel()
        {
            initialize();
            chargementPartie();
        }

        private new void chargementPartie()
        {
            this.Enabled = true;
            Score.Text = "0";
            Score.Visible = false;
            Ecouter.Enabled = true;
            Resultat.Visible = false;
            demarrage = 0;
            carteACliquerTag = "";
            imageCliqueTag = "";

            //récupérer les localisations des cartes
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Enabled = true;
                coordonneesCartes.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
            }

            //mélange des cartes
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                int next = localisation.Next(coordonneesCartes.Count);
                Point p = coordonneesCartes[next];
                image.Location = p;
                coordonneesCartes.Remove(p);
            }

            son1DejaTrouve = false;
            son2DejaTrouve = false;
            son3DejaTrouve = false;
            son4DejaTrouve = false;
            son5DejaTrouve = false;
            son6DejaTrouve = false;
            son7DejaTrouve = false;
            son8DejaTrouve = false;
            son9DejaTrouve = false;
            son10DejaTrouve = false;
            son11DejaTrouve = false;
            son12DejaTrouve = false;

            pictureBox1.Image = Properties.Resources.doudou;
            pictureBox2.Image = Properties.Resources.jardin;
            pictureBox3.Image = Properties.Resources.chateau;
            pictureBox4.Image = Properties.Resources.foret;
            pictureBox5.Image = Properties.Resources.chaise;
            pictureBox6.Image = Properties.Resources.masa;
            pictureBox7.Image = Properties.Resources.yatak;
            pictureBox8.Image = Properties.Resources.kral;
            pictureBox9.Image = Properties.Resources.pont;
            pictureBox10.Image = Properties.Resources.boite;
            pictureBox11.Image = Properties.Resources.merdiven;
            pictureBox12.Image = Properties.Resources.okul;
        }

        private void Ecouter_Click(object sender, EventArgs e)
        {
            demarrage = 1;
            Random choix = new Random();
            int choixSon = choix.Next(1, 13);

            while ((choixSon == 1 & son1DejaTrouve == true) || (choixSon == 2 & son2DejaTrouve == true) || (choixSon == 3 & son3DejaTrouve == true) || (choixSon == 4 & son4DejaTrouve == true) || (choixSon == 5 & son5DejaTrouve == true) || (choixSon == 6 & son6DejaTrouve == true) || (choixSon == 7 & son7DejaTrouve == true) || (choixSon == 8 & son8DejaTrouve == true) || (choixSon == 9 & son9DejaTrouve == true) || (choixSon == 10 & son10DejaTrouve == true) || (choixSon == 11 & son11DejaTrouve == true) || (choixSon == 12 & son12DejaTrouve == true))
            {
                choixSon = choix.Next(1, 13);
            }

            switch (choixSon)
            {
                case 1: System.IO.Stream doudouSon = Properties.Resources.doudouSon;
                    System.Media.SoundPlayer son1 = new System.Media.SoundPlayer(doudouSon);
                    son1.Play();
                    carteACliquerTag = "1";
                    break;

                case 2: System.IO.Stream jardinSon = Properties.Resources.jardinSon;
                    System.Media.SoundPlayer son2 = new System.Media.SoundPlayer(jardinSon);
                    son2.Play();
                    carteACliquerTag = "2";
                    break;

                case 3: System.IO.Stream chateauSon = Properties.Resources.chateauSon;
                    System.Media.SoundPlayer son3 = new System.Media.SoundPlayer(chateauSon);
                    son3.Play();
                    carteACliquerTag = "3";
                    break;

                case 4: System.IO.Stream foretSon = Properties.Resources.foretSon;
                    System.Media.SoundPlayer son4 = new System.Media.SoundPlayer(foretSon);
                    son4.Play();
                    carteACliquerTag = "4";
                    break;

                case 5: System.IO.Stream chaiseSon = Properties.Resources.chaiseSon;
                    System.Media.SoundPlayer son5 = new System.Media.SoundPlayer(chaiseSon);
                    son5.Play();
                    carteACliquerTag = "5";
                    break;

                case 6: System.IO.Stream masaSon = Properties.Resources.masaSon;
                    System.Media.SoundPlayer son6 = new System.Media.SoundPlayer(masaSon);
                    son6.Play();
                    carteACliquerTag = "6";
                    break;

                case 7: System.IO.Stream yatakSon = Properties.Resources.yatakSon;
                    System.Media.SoundPlayer son7 = new System.Media.SoundPlayer(yatakSon);
                    son7.Play();
                    carteACliquerTag = "7";
                    break;

                case 8: System.IO.Stream kralSon = Properties.Resources.kralSon;
                    System.Media.SoundPlayer son8 = new System.Media.SoundPlayer(kralSon);
                    son8.Play();
                    carteACliquerTag = "8";
                    break;

                case 9: System.IO.Stream pontSon = Properties.Resources.pontSon;
                    System.Media.SoundPlayer son9 = new System.Media.SoundPlayer(pontSon);
                    son9.Play();
                    carteACliquerTag = "9";
                    break;

                case 10: System.IO.Stream boiteSon = Properties.Resources.boiteSon;
                    System.Media.SoundPlayer son10 = new System.Media.SoundPlayer(boiteSon);
                    son10.Play();
                    carteACliquerTag = "10";
                    break;

                case 11: System.IO.Stream merdivenSon = Properties.Resources.merdivenSon;
                    System.Media.SoundPlayer son11 = new System.Media.SoundPlayer(merdivenSon);
                    son11.Play();
                    carteACliquerTag = "11";
                    break;

                case 12: System.IO.Stream okulSon = Properties.Resources.okulSon;
                    System.Media.SoundPlayer son12 = new System.Media.SoundPlayer(okulSon);
                    son12.Play();
                    carteACliquerTag = "12";
                    break;
            }          
        }

        private void CliquerReponse(object sender, EventArgs e)
        {
            PictureBox image = (PictureBox) sender;
            imageCliqueTag = (String) image.Tag;

            if (imageCliqueTag == carteACliquerTag)
            {
                System.IO.Stream applaudissement = Properties.Resources.applaudissement;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(applaudissement);
                son.Play();

                if (imageCliqueTag == "1")
                {
                    image.Image = Properties.Resources.dosCarte;
                    son1DejaTrouve = true;
                }
                else if (imageCliqueTag == "2")
                {
                    image.Image = Properties.Resources.dosCarte;
                    son2DejaTrouve = true;
                }
                else if (imageCliqueTag == "3")
                {
                    image.Image = Properties.Resources.dosCarte;
                    son3DejaTrouve = true;
                }
                else if (imageCliqueTag == "4")
                {
                    image.Image = Properties.Resources.dosCarte;
                    son4DejaTrouve = true;
                }
                else if (imageCliqueTag == "5")
                {
                    image.Image = Properties.Resources.dosCarte;
                    son5DejaTrouve = true;
                }
                else if (imageCliqueTag == "6")
                {
                    image.Image = Properties.Resources.dosCarte;
                    son6DejaTrouve = true;
                }
                else if (imageCliqueTag == "7")
                {
                    image.Image = Properties.Resources.dosCarte;
                    son7DejaTrouve = true;
                }
                else if (imageCliqueTag == "8")
                {
                    image.Image = Properties.Resources.dosCarte;
                    son8DejaTrouve = true;
                }
                else if (imageCliqueTag == "9")
                {
                    image.Image = Properties.Resources.dosCarte;
                    son9DejaTrouve = true;
                }
                else if (imageCliqueTag == "10")
                {
                    image.Image = Properties.Resources.dosCarte;
                    son10DejaTrouve = true;
                }
                else if (imageCliqueTag == "11")
                {
                    image.Image = Properties.Resources.dosCarte;
                    son11DejaTrouve = true;
                }
                else if (imageCliqueTag == "12")
                {
                    image.Image = Properties.Resources.dosCarte;
                    son12DejaTrouve = true;
                }

                image.Enabled = false;
                Score.Text = Convert.ToString(Convert.ToInt32(Score.Text) + 1);

                if (Score.Text == "12")
                {
                    MessageBox.Show("Bien joué, tu as fini la partie !", "Bravo !", MessageBoxButtons.OK);
                    Ecouter.Enabled = false;
                    this.Enabled = false;
                }                
            }
            else if (demarrage == 1)
            {
                System.IO.Stream pouet = Properties.Resources.pouet;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(pouet);
                son.Play();
            }
        }
    }
}
