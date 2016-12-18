using System;
using System.IO;
using System.Reflection;
using System.Drawing;
using Ressources;

namespace La_petite_boite
{
    
    class Etoile : System.Windows.Forms.PictureBox
    {
        public Etoile (int L, int choix)
        {
            if (choix == 1)
            {
                this.Image = items.etoileJaune;
            }
            else
            {
                this.Image = items.etoileGrise;
            }
            this.Width = 50;
            this.Height = 50;
            this.Top = 0;
            this.Left = L;
            this.BackColor = Color.Transparent;
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        public Etoile(int L, int T, int choix)
        {
            if (choix == 1)
            {
                this.Image = items.etoileJaune;
            }
            else
            {
                this.Image = items.etoileGrise;
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
            this.Image = items.etoileGrise;
            this.Name = nom;
            this.Width = 50;
            this.Height = 50;
            this.Location = p;
            this.BackColor = Color.Transparent;
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }
        
    }
}
