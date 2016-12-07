using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Jeu;

namespace memory12cartes
{
    public partial class Memory12 : Form
    {
        public Memory12()
        {
            InitializeComponent();
        }
    }

    public partial class Memory12Panel : Jeu.Jeu
    {
        Random localisation = new Random(); //
        List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox
        PictureBox ImageEnAttente1; //la première carte sélectionnée
        PictureBox ImageEnAttente2; //la deuxième carte sélectionnée
        private Panel conteneurCarte;
        private PictureBox carte5;
        private PictureBox carte3;
        private PictureBox carte1;
        private PictureBox carte4Double;
        private PictureBox carte4;
        private PictureBox carte3Double;
        private PictureBox carte6;
        private PictureBox carte6Double;
        private PictureBox carte2Double;
        private PictureBox carte2;
        private PictureBox carte1Double;
        private PictureBox carte5Double;
        private Label label1;
        private Label Score;

        public Memory12Panel()
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
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Enabled = true;
                image.Image = Properties.Resources.dosCarte;
                //récupérer les localisations des cartes
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

        private void jouer (object sender, EventArgs e)
        {
            PictureBox carteCourante = (PictureBox)sender; 
            DialogResult rep;

            //attribution des mots pour chaque pairescselon le tag 
            if ((String)carteCourante.Tag == "1")
            {
                carteCourante.Image = Properties.Resources.orman;
                //lecture du son lié à la carte
                System.IO.Stream ormanSon = Properties.Resources.ormanSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(ormanSon);
                son.Play();            
            }
            else if ((String)carteCourante.Tag == "2")
            {
                carteCourante.Image = Properties.Resources.okul;
                //lecture du son lié à la carte
                System.IO.Stream okulSon = Properties.Resources.okulSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(okulSon);
                son.Play();  
            }
            else if ((String)carteCourante.Tag == "3")
            {
                carteCourante.Image = Properties.Resources.table;
                //lecture du son lié à la carte
                System.IO.Stream tableSon = Properties.Resources.tableSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(tableSon);
                son.Play();  
            }
            else if ((String)carteCourante.Tag == "4")
            {
                carteCourante.Image = Properties.Resources.yatak;
                //lecture du son lié à la carte
                System.IO.Stream yatakSon = Properties.Resources.yatakSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(yatakSon);
                son.Play();  
            }
            else if ((String)carteCourante.Tag == "5")
            {
                carteCourante.Image = Properties.Resources.boite;
                //lecture du son lié à la carte
                System.IO.Stream boiteSon = Properties.Resources.boiteSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(boiteSon);
                son.Play();  
            }
            else if ((String)carteCourante.Tag == "6")
            {
                carteCourante.Image = Properties.Resources.chaise;
                //lecture du son lié à la carte
                System.IO.Stream chaiseSon = Properties.Resources.chaiseSon;
                System.Media.SoundPlayer son = new System.Media.SoundPlayer(chaiseSon);
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

            if (Score.Text == "6")
            {
                MessageBox.Show("Super ! Vous avez fini la partie !","BRAVO !!!");
                this.Enabled = false;
            }
        }
        
    }
}
