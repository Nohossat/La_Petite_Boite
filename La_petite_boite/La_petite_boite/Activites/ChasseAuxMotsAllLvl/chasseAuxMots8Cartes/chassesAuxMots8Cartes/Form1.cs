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

namespace chassesAuxMots8Cartes
{
    public partial class ChasseAuxMots8 : Form
    {
        public ChasseAuxMots8()
        {
            InitializeComponent();
        }
        
    }

    public partial class ChasseAuxMots8Panel : Jeu.Jeu
    {
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Resultat;
        private System.Windows.Forms.Button Ecouter;
        private System.Windows.Forms.Panel conteneurCarte;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;

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

        public ChasseAuxMots8Panel()
        {
            initialize();
            chargementPartie();
        }

        private new void chargementPartie()
        {
            Score.Text = "0";
            Ecouter.Enabled = true;
            demarrage = 0;
            carteACliquerTag = "";
            imageCliqueTag = "";
            son1DejaTrouve = false;
            son2DejaTrouve = false;
            son3DejaTrouve = false;
            son4DejaTrouve = false;
            son5DejaTrouve = false;
            son6DejaTrouve = false;
            son7DejaTrouve = false;
            son8DejaTrouve = false;

            pictureBox1.Image = Properties.Resources.doudou;
            pictureBox2.Image = Properties.Resources.bahce;
            pictureBox3.Image = Properties.Resources.sato;
            pictureBox4.Image = Properties.Resources.orman;
            pictureBox5.Image = Properties.Resources.sandalye;
            pictureBox6.Image = Properties.Resources.table;
            pictureBox7.Image = Properties.Resources.lit;
            pictureBox8.Image = Properties.Resources.roi;

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
        }

        private void Ecouter_Click(object sender, EventArgs e)
        {
            demarrage = 1;
            Random choix = new Random();
            int choixSon = choix.Next(1, 9);

            while ((choixSon == 1 & son1DejaTrouve == true) || (choixSon == 2 & son2DejaTrouve == true) || (choixSon == 3 & son3DejaTrouve == true) || (choixSon == 4 & son4DejaTrouve == true) || (choixSon == 5 & son5DejaTrouve == true) || (choixSon == 6 & son6DejaTrouve == true) || (choixSon == 7 & son7DejaTrouve == true) || (choixSon == 8 & son8DejaTrouve == true))
            {
                choixSon = choix.Next(1, 9);
            }

            switch (choixSon)
            {
                case 1: System.IO.Stream doudouSon = Properties.Resources.doudouSon;
                    System.Media.SoundPlayer son1 = new System.Media.SoundPlayer(doudouSon);
                    son1.Play();
                    carteACliquerTag = "1";
                    break;

                case 2: System.IO.Stream bahceSon = Properties.Resources.bahceSon;
                    System.Media.SoundPlayer son2 = new System.Media.SoundPlayer(bahceSon);
                    son2.Play();
                    carteACliquerTag = "2";
                    break;

                case 3: System.IO.Stream satoSon = Properties.Resources.satoSon;
                    System.Media.SoundPlayer son3 = new System.Media.SoundPlayer(satoSon);
                    son3.Play();
                    carteACliquerTag = "3";
                    break;

                case 4: System.IO.Stream ormanSon = Properties.Resources.ormanSon;
                    System.Media.SoundPlayer son4 = new System.Media.SoundPlayer(ormanSon);
                    son4.Play();
                    carteACliquerTag = "4";
                    break;

                case 5: System.IO.Stream sandalyeSon = Properties.Resources.sandalyeSon;
                    System.Media.SoundPlayer son5 = new System.Media.SoundPlayer(sandalyeSon);
                    son5.Play();
                    carteACliquerTag = "5";
                    break;

                case 6: System.IO.Stream tableSon = Properties.Resources.tableSon;
                    System.Media.SoundPlayer son6 = new System.Media.SoundPlayer(tableSon);
                    son6.Play();
                    carteACliquerTag = "6";
                    break;

                case 7: System.IO.Stream litSon = Properties.Resources.litSon;
                    System.Media.SoundPlayer son7 = new System.Media.SoundPlayer(litSon);
                    son7.Play();
                    carteACliquerTag = "7";
                    break;

                case 8: System.IO.Stream roiSon = Properties.Resources.roiSon;
                    System.Media.SoundPlayer son8 = new System.Media.SoundPlayer(roiSon);
                    son8.Play();
                    carteACliquerTag = "8";
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

                image.Enabled = false;
                Score.Text = Convert.ToString(Convert.ToInt32(Score.Text) + 1);

                if (Score.Text == "8")
                {
                    MessageBox.Show("Bien joué, tu as fini la partie !", "Bravo !");
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
