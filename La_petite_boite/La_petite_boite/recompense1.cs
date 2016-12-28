using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
using System.Diagnostics;
using Ressources;

namespace La_petite_boite
{
    public partial class recompense1 : Form
    {
        public recompense1()
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
                Process.Start("OtobusunTekerlegniYuvarlak.avi");
            }

            private void coloriage(object sender, EventArgs e)
            {
                Process.Start("coloriage1.gif");
                Process.Start("coloriage2.gif");
        }
        }
    }

