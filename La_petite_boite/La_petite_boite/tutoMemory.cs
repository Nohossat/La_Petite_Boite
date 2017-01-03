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

            this.conteneurCarte.Location = new System.Drawing.Point(124, 10);
            conteneur.Controls.Add(this.conteneurCarte);

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
            //on met la souris sur une premiere picturebox
            conteneurCarte.Controls.OfType<PictureBox>().ElementAt(0).Cursor = Cursors.Hand;
           
            p.x = conteneurCarte.Controls.OfType<PictureBox>().ElementAt(0).Location.X + 200;
            p.y = conteneurCarte.Controls.OfType<PictureBox>().ElementAt(0).Location.Y + 200;

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);

            conteneurCarte.Controls.OfType<PictureBox>().ElementAt(0).Image = items.doudou1;
            conteneurCarte.Controls.OfType<PictureBox>().ElementAt(0).BackColor = Color.Transparent;
            Program.petiteBoite.JouerSon(items.doudouFR);
        }

        private void action2()
        {
            //on met la souris sur une premiere picturebox
            conteneurCarte.Controls.OfType<PictureBox>().ElementAt(1).Cursor = Cursors.Hand;

            p.x = conteneurCarte.Controls.OfType<PictureBox>().ElementAt(1).Location.X + 200;
            p.y = conteneurCarte.Controls.OfType<PictureBox>().ElementAt(1).Location.Y + 200;

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);

            conteneurCarte.Controls.OfType<PictureBox>().ElementAt(1).Image = items.doudou1;
            conteneurCarte.Controls.OfType<PictureBox>().ElementAt(1).BackColor = Color.Transparent;
            Program.petiteBoite.JouerSon(items.doudouFR);
        }
        
    }
}
