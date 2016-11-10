using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace La_petite_boite
{
    public partial class tutoMemory : Form
    {
        Assembly _assembly = Assembly.GetExecutingAssembly();
        Stream _imageStream;
        Stream _sonStream;
        Random localisation = new Random(); //
        List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox
        private Panel conteneurCarte;
        private PictureBox doubleCarte2;
        private PictureBox carte2;
        private PictureBox doubleCarte1;
        private PictureBox carte1;
        int compteur = 0;
        System.Media.SoundPlayer sound;

        public tutoMemory()
        {
            InitializeComponent();
            chargementPartie();
            button1.Enabled = false;
            timer1.Enabled = true;
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
                chargementImage("carte1.png", image);
                
            }
        }

        public void chargementImage(String res, PictureBox p)
        {
            //access resource
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("La_petite_boite.Resources.miniJeu." + res);
                Console.WriteLine(res);
            }
            catch
            {
                Console.WriteLine("Error accessing resources!");
            }

            //display image
            try
            {
                p.Image = new Bitmap(_imageStream);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cant create image for picturebox!" + e);
            }
        }

        public void chargementSon(String res, System.Media.SoundPlayer son)
        {
            //access resource
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _sonStream = _assembly.GetManifestResourceStream("La_petite_boite.Resources.miniJeu." + res);
                Console.WriteLine(res);
            }
            catch
            {
                Console.WriteLine("Error accessing resources!");
            }

            //play sound
            try
            {
                son = new System.Media.SoundPlayer(_sonStream);
                son.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine("Cant play the sound" + e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (compteur < 2)
            {
                chargementImage("doudou1.png", (PictureBox)conteneurCarte.Controls[compteur]);
                chargementSon("UnDoudou.wav", sound);
                compteur++;
            }
            else
            {
                timer1.Enabled = false;
                chargementSon("applaudissements.wav", sound);
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
