﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_petite_boite
{
    class récompense
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }
        }

        public partial class recompense : Panel
        {
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.Button button2;

            public recompense()
            {
                initialize();
            }

            private void chanson(object sender, EventArgs e)
            {
                Process player = null;
                //File.WriteAllBytes("OtobusunTekerlegniYuvarlak.avi", Properties.Resources.OtubusunTekerlegniYuvarlak);
                player = Process.Start("OtobusunTekerlegniYuvarlak.avi");
                player.WaitForExit();
            }

            private void coloriage(object sender, EventArgs e)
            {
                //var image= new Bitmap(Properties.Resources.coloriage1);
                //var image1 = new Bitmap(Properties.Resources.coloriage2);
                //image.Save("coloriage1.gif");
                //image1.Save("coloriage2.gif");
                Process.Start("coloriage1.gif");
            }
        }
    }
}
