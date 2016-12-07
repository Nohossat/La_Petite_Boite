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
    public class Lieu : System.Windows.Forms.Panel
    {
        Point position;
        Assembly _assembly;
        Stream _imageStream;
        String imgDebut;
        String imgFin;
        String imgSurvol;
        String map;

        public Lieu (int Top, int Left, int Width, int Height, String imageDebut, String imageSurvol, String imageFin, String map, Point p, String nom)
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
            chargementImage(imageDebut);
        }

        public Lieu ()
        {

        }

        public void chargementImage(String res)
        {
            //accessing image
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("La_petite_boite.Resources.Jeu." + res);
            }
            catch
            {
                Console.WriteLine("Error accessing resources!");
            }

            //display image
            try
            {
                this.BackgroundImage = new Bitmap(_imageStream);
            }
            catch
            {
                Console.WriteLine("cant create image LIEU!");
            }

            this.Update();
        }

        public void chargementDebutImage()
        {
            chargementImage(imgDebut);
        }

        public void chargementSurvolImage()
        {
            chargementImage(imgSurvol);
        }

        public void chargementFinImage()
        {
            chargementImage(imgFin);
        }

        public void chargementMap(Panel p)
        {
            chargementImage(map);

            //accessing image
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("La_petite_boite.Resources.Jeu." + map);
                p.Name = map;
            }
            catch
            {
                Console.WriteLine("Error accessing resources!");
            }

            //display image
            try
            {
                p.BackgroundImage = new Bitmap(_imageStream);
            }
            catch
            {
                Console.WriteLine("cant create image LIEU!");
            }

            this.Update();
        }

        public Point getPosition ()
        {
            return this.position;
        }
    }
}
