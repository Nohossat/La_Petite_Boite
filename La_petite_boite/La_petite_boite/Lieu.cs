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
        Bitmap imgFin;
        Bitmap imgSurvol;
        String map;

        public Lieu (int Top, int Left, int Width, int Height, Bitmap imageDebut, Bitmap imageSurvol, Bitmap imageFin, String map, Point p, String nom)
        {
            this.Name = nom;
            this.Top = Top;
            this.Left = Left;
            this.Width = Width;
            this.Height = Height;
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
            this.position = p;
            this.imgDebut = imageDebut;
            this.imgSurvol = imageSurvol;
            this.imgFin = imageFin;
            this.map = map;
            this.BackgroundImage = imageDebut;
        }

        public Lieu()
        {

        }
        
        public void chargementDebutImage()
        {
            this.BackgroundImage = imgDebut;
        }

        public void chargementSurvolImage()
        {
            this.BackgroundImage = imgSurvol;
        }

        public void chargementFinImage()
        {
            this.BackgroundImage = imgFin;
        }
        
        public Point getPosition()
        {
            return this.position;
        }
    }
}
