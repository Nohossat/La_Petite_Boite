using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace Jeu
{
    public partial class Generics : Form
    {
        public Generics()
        {
            InitializeComponent();
        }
        
    }

    public partial class Jeu : Panel
    {
        Assembly _assembly = Assembly.GetExecutingAssembly();
        Stream _sonStream;

        public Jeu()
        {

        }

        public void chargementPartie()
        {

        }

        public void chargementSon(String res, String dossier, SoundPlayer son)
        {
            //access resource
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _sonStream = _assembly.GetManifestResourceStream("La_petite_boite.Resources" + dossier + "." + res);
                Console.WriteLine(res);
            }
            catch
            {
                Console.WriteLine("Error accessing resources!");
            }

            //play sound
            try
            {
                son = new SoundPlayer(_sonStream);
                son.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine("Cant play the sound" + e);
            }
        }
    }
}
