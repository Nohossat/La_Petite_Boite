using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ressources;

namespace La_petite_boite
{
    public partial class splash : Form
    {
        int compteur = 0;
        public splash()
        {
            InitializeComponent();
            this.BackgroundImage = items.chargement;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            compteur++;

            if (compteur == 15)
            {
                timer1.Stop();
            }
        }
    }
}
