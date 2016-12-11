using Ressources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chasse_aux_mots
{
    public class chasseMots : Jeu.Jeu
    {
        public chasseMots ()
        {

        }

        private new void chargementPartie()
        {

        }

        public void AffichageDosCarte(PictureBox img, ref Boolean trouve)
        {
            img.Image = items.dosCarte;
            trouve = true;
        }

        public void JouerSon(Stream stream, int choix, ref String tag)
        {
            stream.Position = 0;
            SoundPlayer son = new SoundPlayer(stream);
            son.Play();
            tag = choix.ToString();
            son.Dispose();
        }
        
    }
}
