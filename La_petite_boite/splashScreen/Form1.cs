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
using La_petite_boite;
using System.Threading;

namespace splashScreen
{
    public partial class Form1 : Form
    {
        public static petiteBoite petiteBoite;
        int compteur = 0;

        public Form1()
        {
            this.BackgroundImage = items.chargement;
            timer1.Start();

            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            //t.Abort();
        }

        public void splashStart ()
        {
            Application.Run(new petiteBoite());
        }

        private void showMainForm(object sender, EventArgs e)
        {
            //on fait le fade in
            compteur++;

            if (compteur == 10)
            {
                this.Hide();
                timer1.Stop();
                //une fois le fade in effectue on affiche la main form
                petiteBoite = new petiteBoite();
                petiteBoite.Show();
            }
           
        }
    }
}
