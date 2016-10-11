using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_petite_boite
{
    class Lieu : System.Windows.Forms.Panel
    {
        Point position;

        public Lieu (int Top, int Left, int Width, int Height, Image image, Point p, String nom)
        {
            this.Name = nom;
            this.Top = Top;
            this.Left = Left;
            this.Width = Width;
            this.Height = Height;
            this.BackgroundImage = image;
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
            this.position = p;
        }

        public Lieu ()
        {

        }

        public Point getPosition ()
        {
            return this.position;
        }
    }
}
