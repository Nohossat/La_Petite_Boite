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
using System.Drawing.Text;

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

            if (fadein == false && this.Opacity == 0.7)
            {
                fadein = true;
                timer1.Stop();
            }
            
            //dans un deuxieme temps, fade out
            /* if (fadein == true)
             {
                 this.Opacity -= 0.01;
             }

             if (fadein == true && this.Opacity == 0.90)
             {
                 timer1.Stop();
             }*/
        }

        private void splash_Load(object sender, EventArgs e)
        {
            //on determine la resolution de la fenetre
            Double flagResolution = Screen.PrimaryScreen.Bounds.Height / Screen.PrimaryScreen.Bounds.Width;
            
            if (flagResolution == 1366 / 768)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.ClientSize = new Size(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y);
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.ClientSize = new Size(1292, 726);
                this.Size = new Size(1292, 728);
            }
        }
    }
}
