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

namespace Chasse_aux_mots
{
    public partial class ChasseAuxMots : Form
    {
        public ChasseAuxMots()
        {
            InitializeComponent();
        }
    }

    public partial class ChasseAuxMotsPanel : Jeu.Jeu
    {
        private Panel conteneurCarte;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button Ecouter;
        private Label Resultat;
        private Label Score;

        Random localisation = new Random(); //
        List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox

        String carteACliquerTag;
        String imageCliqueTag;
        int demarrage;
        Boolean son1DejaTrouve;
        Boolean son2DejaTrouve;
        Boolean son3DejaTrouve;
        Boolean son4DejaTrouve;

        public ChasseAuxMotsPanel()
        {
            initialize();
            chargementPartie();
        }

        private new void chargementPartie()
        {
            this.Enabled = true;
            Score.Text = "0";
            Ecouter.Enabled = true;
            demarrage = 0;
            carteACliquerTag = "";
            imageCliqueTag = "";
            son1DejaTrouve = false;
            son2DejaTrouve = false;
            son3DejaTrouve = false;
            son4DejaTrouve = false;

            pictureBox1.Image = Properties.Resources.doudou;
            pictureBox2.Image = Properties.Resources.bahce;
            pictureBox3.Image = Properties.Resources.sato;
            pictureBox4.Image = Properties.Resources.roi;

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
            int choixSon = choix.Next(1, 5);

            while ((choixSon == 3 & son3DejaTrouve == true) || (choixSon == 2 & son2DejaTrouve == true) || (choixSon == 1 & son1DejaTrouve == true) || (choixSon == 4 & son4DejaTrouve == true))
            {
                choixSon = choix.Next(1, 5);
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

                case 4: System.IO.Stream roiSon = Properties.Resources.roiSon;
                    System.Media.SoundPlayer son4 = new System.Media.SoundPlayer(roiSon);
                    son4.Play();
                    carteACliquerTag = "4";
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

                image.Enabled = false;
                Score.Text = Convert.ToString(Convert.ToInt32(Score.Text) + 1);

                if (Score.Text == "4")
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
