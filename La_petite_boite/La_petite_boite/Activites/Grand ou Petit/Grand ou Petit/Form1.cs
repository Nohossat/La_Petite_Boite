using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jeu;
using Ressources;

namespace Grand_ou_Petit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new GrandOuPetit());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new GrandOuPetit8Panel());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new GrandOuPetit12Panel());
        }
    }

    public partial class GrandOuPetit : GrandOuPetitClass
    {
        
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        

        public GrandOuPetit()
        {
            initialize();

            finalScore = 4;
            //images
            img.Add(items.chateau1);
            img.Add(items.coffre1);
            img.Add(items.jardin1);
            img.Add(items.pont1);

            //sons pour les grandes icones
            sons.Add(items.grandChateauFR);
            sons.Add(items.grandCoffreFR);
            sons.Add(items.grandJardinTurc);
            sons.Add(items.grandPontTurc);

            //sons pour les petites icones
            sons.Add(items.petitChateauFR);
            sons.Add(items.petitCoffreFR);
            sons.Add(items.petitJardinTurc);
            sons.Add(items.petitPontTurc);

            chargementPartie();
            
        }
    }

    public partial class GrandOuPetit8Panel : GrandOuPetitClass
    {
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox22;

        public GrandOuPetit8Panel()
        {
            initialize();
            
            finalScore = 8;
            //images
            img.Add(items.chateau1);
            img.Add(items.coffre1);
            img.Add(items.jardin1);
            img.Add(items.pont1);
            img.Add(items.lit1);
            img.Add(items.table1);
            img.Add(items.chaise1);
            img.Add(items.foret1);

            //sons pour les grandes icones
            sons.Add(items.grandChateauTurc);
            sons.Add(items.grandCoffreFR);
            sons.Add(items.grandJardinTurc);
            sons.Add(items.grandPontFR);
            sons.Add(items.grandLitTurc);
            sons.Add(items.grandTableTurc);
            sons.Add(items.grandeChaiseFR);
            sons.Add(items.grandeForetFR);

            //sons pour les petites icones
            sons.Add(items.petitChateauTurc);
            sons.Add(items.petitCoffreFR);
            sons.Add(items.petitJardinTurc);
            sons.Add(items.petitPontFR);
            sons.Add(items.petitLitTurc);
            sons.Add(items.petitTableTurc);
            sons.Add(items.petiteChaiseFR);
            sons.Add(items.petiteForetFR);

            chargementPartie();
        }
    }

    public partial class GrandOuPetit12Panel : GrandOuPetitClass
    {
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox25;

        public GrandOuPetit12Panel()
        {
            initialize();
            
            finalScore = 10;
            
            //images
            img.Add(items.chateau1);
            img.Add(items.coffre1);
            img.Add(items.jardin1);
            img.Add(items.pont1);
            img.Add(items.lit1);
            img.Add(items.table1);
            img.Add(items.chaise1);
            img.Add(items.foret1);
            img.Add(items.roi1);
            img.Add(items.escalier1);

            //sons pour les grandes icones
            sons.Add(items.grandChateauTurc);
            sons.Add(items.grandCoffreFR);
            sons.Add(items.grandJardinTurc);
            sons.Add(items.grandPontFR);
            sons.Add(items.grandLitTurc);
            sons.Add(items.grandTableTurc);
            sons.Add(items.grandeChaiseFR);
            sons.Add(items.grandeForetFR);
            sons.Add(items.grandRoiTurc);
            sons.Add(items.grandEscalierFR);

            //sons pour les petites icones
            sons.Add(items.petitChateauTurc);
            sons.Add(items.petitCoffreFR);
            sons.Add(items.petitJardinTurc);
            sons.Add(items.petitPontFR);
            sons.Add(items.petitLitTurc);
            sons.Add(items.petitTableTurc);
            sons.Add(items.petiteChaiseFR);
            sons.Add(items.petiteForetFR);
            sons.Add(items.petitRoiTurc);
            sons.Add(items.petitEscalierFR);

            chargementPartie();
        }
    }
}
