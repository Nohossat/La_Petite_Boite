using System;
using System.IO;
using System.Reflection;
using System.Drawing;

namespace La_petite_boite
{
    
    class Etoile : System.Windows.Forms.PictureBox
    {
        public Etoile (int L, int choix)
        {
            if (choix == 1)
            {
                Program.petiteBoite.chargementImage("etoileJaune.png", "Jeu", this);
            }
            else
            {
                Program.petiteBoite.chargementImage("etoileGrise.png", "Jeu", this);
            }
            this.Width = 50;
            this.Height = 50;
            this.Top = 20;
            this.Left = L;
            this.BackColor = Color.Transparent;
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        public Etoile(int L, int T, int choix)
        {
            if (choix == 1)
            {
                Program.petiteBoite.chargementImage("etoileJaune.png", "Jeu", this);
            }
            else
            {
                Program.petiteBoite.chargementImage("etoileGrise.png", "Jeu", this);
            }
            this.Width = 50;
            this.Height = 50;
            this.Top = T;
            this.Left = L;
            this.BackColor = Color.Transparent;
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        public Etoile (Point p, String nom)
        {
            Program.petiteBoite.chargementImage("etoileGrise.png", "Jeu", this);
            this.Name = nom;
            this.Width = 50;
            this.Height = 50;
            this.Location = p;
            this.BackColor = Color.Transparent;
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }
        
    }
}
