using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_petite_boite
{
    public class Lieu : Panel
    {
        Point position;
        Bitmap imgDebut;
        Bitmap map;
        Bitmap imgSurvol;
        int ordonee;
        int abs;

        public Lieu (int Top, int Left, int Width, int Height, Bitmap imageDebut, Bitmap imageSurvol, Bitmap map, String nom)
        {
            this.Name = nom;
            this.ordonee = Top;
            this.abs = Left;
            this.Width = Width;
            this.Height = Height;
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
            this.imgDebut = imageDebut;
            this.imgSurvol = imageSurvol;
            this.map = map;
            this.BackgroundImage = imageDebut;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Cursor = Cursors.Hand;
            
        }

        public Lieu()
        {

        }

        public int getOrdonne ()
        {
            return this.ordonee;
        }

        public int getAbs()
        {
            return this.abs;
        }

        public void chargementDebutImage()
        {
            this.BackgroundImage = imgDebut;
        }

        public void chargementSurvolImage()
        {
            this.BackgroundImage = imgSurvol;
        }

        public Bitmap chargementLieuInactif()
        {
            this.Hide();

            return this.map;
        }
        
        public Point getPosition()
        {
            return this.position;
        }

        public String getName()
        {
            return this.Name;
        }

        public void setPosition(Point p)
        {
            this.position = p;
        }
    }
}
