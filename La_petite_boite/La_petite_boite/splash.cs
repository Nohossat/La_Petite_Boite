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
        bool fadein = false;

        public splash()
        {
            InitializeComponent();
            //il faut forcer le full screen
            this.BackgroundImage = items.chargement;
            this.Opacity = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // opacity a 0 = transparent et 1 = opaque

            //dans un premier temps fadein
            if (fadein == false)
            {
                this.Opacity += 0.05;
            }

            if (fadein == false && this.Opacity == 1)
            {
                fadein = true;
            }
            
            //dans un deuxieme temps, fade out
             if (fadein == true)
             {
                 this.Opacity -= 0.01;
             }

             if (fadein == true && this.Opacity == 0.90)
             {
                 timer1.Stop();
             }
        }
    }
}
