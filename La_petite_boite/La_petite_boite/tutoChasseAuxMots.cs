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
    public partial class tutoChasseAuxMots : Form
    {
        Assembly _assembly = Assembly.GetExecutingAssembly();
        Stream _imageStream;
        Stream _sonStream;
        private Panel conteneurCarte;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button Ecouter;

        Random localisation = new Random(); //
        List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox
        List<String> sounds = new List<String>();
        String carteACliquerTag;
        String imageCliqueTag;
        int demarrage;
        Boolean son1DejaTrouve;
        Boolean son2DejaTrouve;

        System.Media.SoundPlayer son;

        int compteur = 0;
        public tutoChasseAuxMots()
        {
            InitializeComponent();
            ChasseAuxMots_Load();
            timer1.Enabled = true;
        }

        private void ChasseAuxMots_Load()
        {
            this.Enabled = true;
            Ecouter.Enabled = true;
            demarrage = 0;
            carteACliquerTag = "";
            imageCliqueTag = "";
            son1DejaTrouve = false;
            son2DejaTrouve = false;

            chargementImage("doudou1.png", pictureBox1);
            chargementImage("jardin1.png", pictureBox2);
            sounds.Add("UnDoudou.wav");
            sounds.Add("Bahce.wav");
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
                chargementSon(sounds.ElementAt(compteur), son);
                chargementImage("carte1.png", (PictureBox)conteneurCarte.Controls[compteur]);
                chargementSon("applaudissements.wav", son);
                compteur++;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
