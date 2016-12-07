using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Media;

namespace La_petite_boite
{
    public partial class tutoMemory : Form
    {
        
        private Panel conteneurCarte;
        private PictureBox doubleCarte2;
        private PictureBox carte2;
        private PictureBox doubleCarte1;
        private PictureBox carte1;
        Random localisation = new Random(); //
        List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox
        int compteur = 0;
        

        public tutoMemory()
        {
            InitializeComponent();
            chargementPartie();
            Cursor myCursor = new Cursor("../../Resources/Jeu/souris.cur");
            this.Cursor = myCursor;
            button1.Enabled = false;
            timer1.Enabled = true;
        }

        public void chargementPartie()
        {
            
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
                Program.petiteBoite.chargementImage("carte1.png", "miniJeu", image);
                
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();

            if (compteur < 2)
            {
                Program.petiteBoite.chargementImage("doudou1.png", "miniJeu", (PictureBox)conteneurCarte.Controls[compteur]);
                Program.petiteBoite.chargementSon("UnDoudou.wav", "miniJeu", sound);
                compteur++;
            }
            else
            {
                timer1.Enabled = false;
                Program.petiteBoite.chargementSon("applaudissements.wav", "miniJeu", sound);
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
