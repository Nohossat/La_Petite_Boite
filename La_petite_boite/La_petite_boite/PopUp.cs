using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_petite_boite
{
    public partial class PopUp : Form
    {
        public PopUp()
        {
            InitializeComponent();
        }

        private void CarteClick(object sender, EventArgs e)
        {
            Program.petiteBoite.Carte();

            //on referme la form
            this.Close();
            this.Dispose();
        }

        private void Rejouer1Click(object sender, EventArgs e)
        {
            Program.petiteBoite.epreuvesO.ElementAt(Program.petiteBoite.IndiceJeu).chargementPartie();
            //on referme la form
            this.Close();
            this.Dispose();
        }

        private void Rejouer2Click(object sender, EventArgs e)
        {
            Program.petiteBoite.chevalier.epreuvesFacultatives().ElementAt(Program.petiteBoite.IndiceJeu).chargementPartie();
            //on referme la form
            this.Close();
            this.Dispose();
        }
    }
}
