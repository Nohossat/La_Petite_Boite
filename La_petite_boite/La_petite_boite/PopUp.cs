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
            //this.Controls.Remove(Program.petiteBoite.Jeu);
            //Program.petiteBoite.Carte();
            Program.petiteBoite.choixFinMiniJeu = 1;
            //on referme la form
            this.Close();
            this.Dispose();
        }

        private void Rejouer1Click(object sender, EventArgs e)
        {
            //Program.petiteBoite.epreuvesO.ElementAt(Program.petiteBoite.IndiceJeu).chargementPartie();

            Program.petiteBoite.choixFinMiniJeu = 2;
            //on referme la form
            this.Close();
            this.Dispose();
        }

        private void Rejouer2Click(object sender, EventArgs e)
        {
            //Program.petiteBoite.chevalier.epreuvesFacultatives().ElementAt(Program.petiteBoite.IndiceJeu).chargementPartie();


            Program.petiteBoite.choixFinMiniJeu = 2;

            //on referme la form
            this.Close();
            this.Dispose();
        }
    }
}
