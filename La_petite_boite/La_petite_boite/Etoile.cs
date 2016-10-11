using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_petite_boite
{
    class Etoile : System.Windows.Forms.PictureBox
    {
       
        public Etoile (int L, int choix)
        {
            if (choix == 1)
            {
                this.Image = Properties.Resources.etoileJaune1;
            }
            else
            {
                this.Image = Properties.Resources.etoileGrise1;
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
                this.Image = Properties.Resources.etoileJaune1;
            }
            else
            {
                this.Image = Properties.Resources.etoileGrise1;
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
            this.Name = nom;
            this.Image = Properties.Resources.etoileGrise1;
            this.Width = 50;
            this.Height = 50;
            this.Location = p;
            this.BackColor = Color.Transparent;
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }
        
    }
}
