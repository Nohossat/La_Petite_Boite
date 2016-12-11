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

        public Jeu()
        {

        }

        public void chargementPartie()
        {

        }

        public void JouerSon(Stream stream)
        {
            stream.Position = 0;
            SoundPlayer son = new SoundPlayer(stream);
            son.Play();
            son.Dispose();
        }

    }
}
