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
    public class Lieu : System.Windows.Forms.Panel
    {
        Point position;
        Assembly _assembly;
        Stream _imageStream;

        public Lieu (int Top, int Left, int Width, int Height, String image, Point p, String nom)
        {
            //try
            //{
            //    _assembly = Assembly.GetExecutingAssembly();
            //    _imageStream = _assembly.GetManifestResourceStream(image);
            //    this.BackgroundImage = new Bitmap(_imageStream);

            //}
            //catch
            //{
            //    Console.WriteLine("Error accessing resources nono!");
            //}

            chargementImage(image);
            this.Name = nom;
            this.Top = Top;
            this.Left = Left;
            this.Width = Width;
            this.Height = Height;
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
            this.position = p;
            
        }

        public Lieu ()
        {

        }

        private void chargementImage(String res)
        {
            //accessing image
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("La_petite_boite.Resources.Jeu." + res);
                Console.WriteLine(res);
            }
            catch
            {
                Console.WriteLine("Error accessing resources!");
            }

            //display image
            try
            {
                this.BackgroundImage = new Bitmap(_imageStream);
                Console.WriteLine("Cest cree");
            }
            catch
            {
                Console.WriteLine("cant create image!");
            }
        }

        public Point getPosition ()
        {
            return this.position;
        }
    }
}
