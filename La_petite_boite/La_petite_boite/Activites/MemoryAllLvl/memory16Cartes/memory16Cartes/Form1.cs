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

namespace memory16Cartes
{
    public partial class Memory16 : Form
    {
        public Memory16()
        {
            InitializeComponent();
        }
    }

    public partial class Memory16Panel : Jeu.Jeu
    {
        Random localisation = new Random(); //
        List<Point> coordonnesCartes = new List<Point>(); //liste des localisations des PictureBox
        PictureBox ImageEnAttente1; //la première carte sélectionnée
        PictureBox ImageEnAttente2; //la deuxième carte sélectionnée

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Panel conteneurCarte;
        private System.Windows.Forms.PictureBox carte9Double;
        private System.Windows.Forms.PictureBox carte9;
        private System.Windows.Forms.PictureBox carte8double;
        private System.Windows.Forms.PictureBox carte8;
        private System.Windows.Forms.PictureBox carte7Double;
        private System.Windows.Forms.PictureBox carte7;
        private System.Windows.Forms.PictureBox carte6Double;
        private System.Windows.Forms.PictureBox carte6;
        private System.Windows.Forms.PictureBox carte5Double;
        private System.Windows.Forms.PictureBox carte5;
        private System.Windows.Forms.PictureBox carte4Double;
        private System.Windows.Forms.PictureBox carte4;
        private System.Windows.Forms.PictureBox carte3Double;
        private System.Windows.Forms.PictureBox carte3;
        private System.Windows.Forms.PictureBox carte2Double;
        private System.Windows.Forms.PictureBox carte2;
        private System.Windows.Forms.PictureBox carte1Double;
        private System.Windows.Forms.PictureBox carte1;

        public Memory16Panel()
        {
            initialize();
            chargementPartie();
        }
        
        private new void chargementPartie()
        {
            Score.Text = "0"; //initialisation du score à zéro
            Score.Visible = false;
            label1.Visible = false;
            ImageEnAttente1 = null; //initialisation à null
            ImageEnAttente2 = null; //initialisation à null
            this.Enabled = true;
            //récupérer les localisations des cartes
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Enabled = true;
                coordonnesCartes.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
            }

            //mélange des cartes
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                int next = localisation.Next(coordonnesCartes.Count);
                Point p = coordonnesCartes[next];
                image.Location = p;
                coordonnesCartes.Remove(p);
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
                carteCourante.Image = Properties.Resources.ecole;
                //lecture du son lié à la carte
                System.IO.Stream ecoleSon = Properties.Resources.ecoleSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(ecoleSon);
                son.Play();            
            }
            else if ((String)carteCourante.Tag == "2")
            {
                carteCourante.Image = Properties.Resources.boite;
                //lecture du son lié à la carte
                System.IO.Stream boiteSon = Properties.Resources.boiteSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(boiteSon);
                son.Play();  
            }
            else if ((String)carteCourante.Tag == "3")
            {
                carteCourante.Image = Properties.Resources.lit;
                //lecture du son lié à la carte
                System.IO.Stream litSon = Properties.Resources.litSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(litSon);
                son.Play();  
            }
            else if ((String)carteCourante.Tag == "4")
            {
                carteCourante.Image = Properties.Resources.pont;
                //lecture du son lié à la carte
                System.IO.Stream pontSon = Properties.Resources.pontSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(pontSon);
                son.Play();  
            }
            else if ((String)carteCourante.Tag == "5")
            {
                carteCourante.Image = Properties.Resources.masa;
                //lecture du son lié à la carte
                System.IO.Stream masaSon = Properties.Resources.masaSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(masaSon);
                son.Play();  
            }
            else if ((String)carteCourante.Tag == "6")
            {
                carteCourante.Image = Properties.Resources.merdiven;
                //lecture du son lié à la carte
                System.IO.Stream merdivenSon = Properties.Resources.merdivenSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(merdivenSon);
                son.Play();  
            }
            else if ((String)carteCourante.Tag == "7")
            {
                carteCourante.Image = Properties.Resources.orman;
                //lecture du son lié à la carte
                System.IO.Stream ormanSon = Properties.Resources.ormanSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(ormanSon);
                son.Play();
            }
            else if ((String)carteCourante.Tag == "8")
            {
                carteCourante.Image = Properties.Resources.pijama;
                //lecture du son lié à la carte
                System.IO.Stream pijamaSon = Properties.Resources.pijamaSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(pijamaSon);
                son.Play();
            }
            else if ((String)carteCourante.Tag == "9")
            {
                carteCourante.Image = Properties.Resources.sato;
                //lecture du son lié à la carte
                System.IO.Stream satoSon = Properties.Resources.satoSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(satoSon);
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
                        System.IO.Stream applaudissement = Properties.Resources.applaudissement;
                        System.Media.SoundPlayer son = new System.Media.SoundPlayer(applaudissement);
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

            if (Score.Text == "9")
            {
                MessageBox.Show("Super ! Vous avez fini la partie !","BRAVO !!!");
                this.Enabled = false;
            }
        }
        
    }
}
