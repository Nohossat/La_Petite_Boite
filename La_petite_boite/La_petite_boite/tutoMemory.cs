﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Media;
using Ressources;
using System.Linq;

namespace La_petite_boite
{
    public partial class tutoMemory : PopForm
    {
        
        public Panel conteneurCarte;
        public PictureBox doubleCarte2;
        public PictureBox carte2;
        public PictureBox doubleCarte1;
        public PictureBox carte1;
        Random localisation = new Random(); 
        List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox
        

        public tutoMemory() : base()
        {
            InitializeComponent();

            tableauFonctions.Add(action1);
            tableauFonctions.Add(action2);
            tableauFonctions.Add(action3);

            chargementPartie();
            //timer1.Enabled = true;

            System.Threading.Thread.Sleep(1000);
            timer2.Enabled = true;
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
                image.Enabled = true;
                image.Image = items.dosCarte;
                image.Cursor = Cursors.Hand;
                image.Size = new Size(130, 160);
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.TabStop = false;
                image.BackColor = Color.Transparent;
            }
        }

        private void action1()
        {
            conteneurCarte.Controls.OfType<PictureBox>().ElementAt(0).Image = items.doudou1;
            Program.petiteBoite.JouerSon(items.doudouFR);
        }

        private void action2()
        {
            conteneurCarte.Controls.OfType<PictureBox>().ElementAt(1).Image = items.doudou1;
            Program.petiteBoite.JouerSon(items.doudouFR);
        }

        private void action3()
        {
            Program.petiteBoite.JouerSon(items.applaudissement);
        }
        
        
    }
}
