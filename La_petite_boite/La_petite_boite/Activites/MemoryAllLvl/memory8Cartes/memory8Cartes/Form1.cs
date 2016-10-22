using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory8Cartes
{
    public partial class Memory8 : Form
    {
        
        public Memory8()
        {
            InitializeComponent();
        }
    }

    public partial class MemoryPanel : Panel
    {     
        Random localisation = new Random(); //
        List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox

        PictureBox ImageEnAttente1; //la première carte sélectionnée
        PictureBox ImageEnAttente2; //la deuxième carte sélectionnée
        private Panel conteneurCarte;
        private PictureBox doubleCarte4;
        private PictureBox carte4;
        private PictureBox doubleCarte3;
        private PictureBox carte3;
        private PictureBox doubleCarte2;
        private PictureBox carte2;
        private PictureBox doubleCarte1;
        private PictureBox carte1;
        private Label Score;
        private System.Windows.Forms.Label label1;

        public MemoryPanel()
        {

            initialize();
            chargementPartie();
        }

        public void chargementPartie()
        {
            Score.Text = "0"; //initialisation du score à zéro
            this.label1.Text = "Score";
            Score.Visible = false;
            label1.Visible = false;
            
            ImageEnAttente1 = null; //initialisation à null
            ImageEnAttente2 = null; //initialisation à null
            this.Enabled = true;
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
            
            //le dos des cartes est affiché
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Image = Properties.Resources.dosCarte;
            }
        }

        private void jouer (object sender, EventArgs e)
        {
            PictureBox carteCourante = (PictureBox)sender; 
            DialogResult rep;

            //attribution des mots pour chaque pairescselon le tag 
            if ((String)carteCourante.Tag == "1")
            {
                carteCourante.Image = Properties.Resources.doudou;
                //lecture du son lié à la carte
                System.IO.Stream doudouSon = Properties.Resources.doudouSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(doudouSon);
                son.Play();            
            }
            else if ((String)carteCourante.Tag == "2")
            {
                carteCourante.Image = Properties.Resources.sato;
                //lecture du son lié à la carte
                System.IO.Stream satoSon = Properties.Resources.satoSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(satoSon);
                son.Play();  
            }
            else if ((String)carteCourante.Tag == "3")
            {
                carteCourante.Image = Properties.Resources.bahce;
                //lecture du son lié à la carte
                System.IO.Stream bahceSon = Properties.Resources.bahceSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(bahceSon);
                son.Play();  
            }
            else if ((String)carteCourante.Tag == "4")
            {
                carteCourante.Image = Properties.Resources.roi;
                //lecture du son lié à la carte
                System.IO.Stream roiSon = Properties.Resources.roiSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(roiSon);
                son.Play();  
            }

            //contrôles sur les cartes sélectionnées
            if (ImageEnAttente1 == null)
            {
                ImageEnAttente1 = carteCourante;
                ImageEnAttente1.Enabled = false; //évite le fait de pouvoir cliquer 2 fois sur une carte       
            }
            else if (ImageEnAttente1 != null && ImageEnAttente2 == null)
            {
                ImageEnAttente2 = carteCourante;
                ImageEnAttente1.Enabled = true;
            }

            if (ImageEnAttente1 != null && ImageEnAttente2 != null)
            {
                if (ImageEnAttente1.Tag == ImageEnAttente2.Tag)
                {
                    rep = MessageBox.Show("As-tu entendu la même chose ?", "Memory", MessageBoxButtons.YesNo);
                    if (rep == DialogResult.Yes)
                    {
                        System.IO.Stream applaudissementSon = Properties.Resources.applaudissement;
                        System.Media.SoundPlayer son = new System.Media.SoundPlayer(applaudissementSon);
                        son.Play();  

                        ImageEnAttente1.Enabled = false;
                        ImageEnAttente2.Enabled = false;

                        ImageEnAttente1 = null;
                        ImageEnAttente2 = null;

                        Score.Text = Convert.ToString(Convert.ToInt32(Score.Text) + 1);
                    }
                    else
                    {
                        System.IO.Stream pouet = Properties.Resources.pouet;
                        System.Media.SoundPlayer son = new System.Media.SoundPlayer(pouet);
                        son.Play(); 

                        MessageBox.Show("En est-tu sûr ? Ré-essaye !");
                        ImageEnAttente1.Image = Properties.Resources.dosCarte;
                        ImageEnAttente2.Image = Properties.Resources.dosCarte;
                        ImageEnAttente1 = null;
                        ImageEnAttente2 = null;
                    }
                }
                else
                {
                    rep = MessageBox.Show("As-tu entendu la même chose ?","Memory",MessageBoxButtons.YesNo);
                    if (rep == DialogResult.Yes)
                    {
                        if (ImageEnAttente1.Tag != ImageEnAttente2.Tag)
                        {
                            System.IO.Stream pouet = Properties.Resources.pouet;
                            System.Media.SoundPlayer son = new System.Media.SoundPlayer(pouet);
                            son.Play();

                            MessageBox.Show("Les sons ne sont pas les mêmes... Ré-essaye !");
                        }
                        ImageEnAttente1.Image = Properties.Resources.dosCarte;
                        ImageEnAttente2.Image = Properties.Resources.dosCarte;
                        ImageEnAttente1 = null;
                        ImageEnAttente2 = null;
                    }
                    else
                    {
                        ImageEnAttente1.Image = Properties.Resources.dosCarte;
                        ImageEnAttente2.Image = Properties.Resources.dosCarte;
                        ImageEnAttente1 = null;
                        ImageEnAttente2 = null;
                    }
                }
            }

            if (Score.Text == "4")
            {
                MessageBox.Show("Super ! Vous avez fini la partie !","BRAVO !!!");
                this.Enabled = false;
                chargementPartie();
                
            }
        }
        
    }

              
}
