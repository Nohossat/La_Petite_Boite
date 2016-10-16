using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_petite_boite
{
    
    class Etoile : System.Windows.Forms.PictureBox
    {
        Stream _imageStream;
        Assembly _assembly;

        public Etoile (int L, int choix)
        {
            if (choix == 1)
            {
                chargementImage("etoileJaune1");
            }
            else
            {
                chargementImage("etoileGrise1");
            }
            this.Image = new Bitmap(_imageStream);
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
                chargementImage("etoileJaune1");
            }
            else
            {
                chargementImage("etoileGrise1");
            }
            this.Image = new Bitmap(_imageStream);
            this.Width = 50;
            this.Height = 50;
            this.Top = T;
            this.Left = L;
            this.BackColor = Color.Transparent;
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        public Etoile (Point p, String nom)
        {
            chargementImage("etoileGrise1");
            this.Name = nom;
            this.Width = 50;
            this.Height = 50;
            this.Location = p;
            this.BackColor = Color.Transparent;
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void chargementImage(String res)
        {
            //accessing image
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("La_petite_boite.Resources.Jeu." + res + ".png");
            }
            catch
            {
                Console.WriteLine("Error accessing resources!");
            }

            //creating image
            
            try
            {
                this.Image = new Bitmap(_imageStream);
                Console.Write("Cest cree");
            }
            catch
            {
                Console.WriteLine("Cant create image");
            }
        }

    }
}
