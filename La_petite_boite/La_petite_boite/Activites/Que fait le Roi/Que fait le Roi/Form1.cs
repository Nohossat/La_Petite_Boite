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

namespace Que_fait_le_Roi
{
    public partial class QueFaitLeRoi : Form
    {
        public QueFaitLeRoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //QuefaitleRoi4
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new QueFaitLeRoi4Panel());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //QuefaitleRoi8
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new QueFaitLeRoi8Panel());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //QuefaitleRoi12
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new QueFaitLeRoi12Panel());
        }
    }

    public partial class QueFaitLeRoi4Panel : QueFaitLeRoiClass
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        

        public QueFaitLeRoi4Panel()
        {
            initialize();
            chargementPartie();
            score = 0;
            finalScore = 4;
            button1.Tag = "1";
            button1.Text = "Le roi rentre au château.";
            button2.Tag = "2";
            button2.Text = "Kral okula girer.";
            button3.Tag = "3";
            button3.Text = "Le roi traverse la forêt.";
            button4.Tag = "4";
            button4.Text = "Kral bahceyi gecer.";

            //sons pour les boutons
            sons.Add(items.roiRentreAuChateauFR); //0
            sons.Add(items.roiVaALecoleTurc); //1
            sons.Add(items.roiTraverseLaForetFR); //2
            sons.Add(items.roiTraverseLeJardinTurc); //3

            //sons pour les images
            sons.Add(items.chateauFR); //4
            sons.Add(items.ecoleTurc); //5
            sons.Add(items.foretFR); //6
            sons.Add(items.jardinTurc); //7

            //picturebox
            this.pictureBox1.Image = items.chateau1;
            this.pictureBox2.Image = items.ecole1;
            this.pictureBox3.Image = items.foret1;
            this.pictureBox4.Image = items.jardin1;
        }
    }

    public partial class QueFaitLeRoi8Panel : QueFaitLeRoiClass
    {
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        

        public QueFaitLeRoi8Panel()
        {
            initialize();
            chargementPartie();
            score = 0;
            finalScore = 8;
            button1.Tag = "1";
            button1.Text = "Kral şatoya girer.";
            button2.Tag = "2";
            button2.Text = "Le roi rentre à l'école.";
            button3.Tag = "3";
            button3.Text = "Kral ormani geçer.";
            button4.Tag = "4";
            button4.Text = "Le roi traverse le jardin.";
            button5.Tag = "5";
            button5.Text = "Kral merdivenleri cikar.";
            button6.Tag = "6";
            button6.Text = "Le roi grimpe sur le lit.";
            button7.Tag = "7";
            button7.Text = "Kral sandalyeye cikar.";
            button8.Tag = "8";
            button8.Text = "Qu'est-ce qu'il y a dans cette boite ?";

            //sons pour les boutons
            sons.Add(items.roiRentreAuChateauTurc);
            sons.Add(items.roiVaALecoleFR);
            sons.Add(items.roiTraverseLaForetTurc); 
            sons.Add(items.roiTraverseLeJardinFR); 
            sons.Add(items.roiMonteEscalierTurc); 
            sons.Add(items.roiMonteLitFR); 
            sons.Add(items.roiMonteChaiseTurc); 
            sons.Add(items.questionBoiteFR); 

            //sons pour les images
            sons.Add(items.chateauTurc); 
            sons.Add(items.ecoleFR); 
            sons.Add(items.foretTurc); 
            sons.Add(items.jardinFR); 
            sons.Add(items.escalierTurc); 
            sons.Add(items.litFR); 
            sons.Add(items.chaiseTurc); 
            sons.Add(items.coffreFR); 

            //picturebox
            this.pictureBox1.Image = items.chateau1;
            this.pictureBox2.Image = items.ecole1;
            this.pictureBox3.Image = items.foret1;
            this.pictureBox4.Image = items.jardin1;
            this.pictureBox12.Image = items.escalier1;
            this.pictureBox13.Image = items.lit1;
            this.pictureBox14.Image = items.chaise1;
            this.pictureBox16.Image = items.coffre1;
        }
        
    }

   public partial class QueFaitLeRoi12Panel : QueFaitLeRoiClass
    {
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        

        public QueFaitLeRoi12Panel()
        {
            initialize();
            chargementPartie();
            score = 0;
            finalScore = 12;

            button1.Tag = "1";
            button1.Text = "Le roi rentre au château.";
            button2.Tag = "2";
            button2.Text = "Kral okula girer.";
            button3.Tag = "3";
            button3.Text = "Le roi traverse la forêt.";
            button4.Tag = "4";
            button4.Text = "Kral bahceyi gecer.";
            button5.Tag = "5";
            button5.Text = "Le roi monte l'escalier.";
            button6.Tag = "6";
            button6.Text = "Kral yataga cikar.";
            button7.Tag = "7";
            button7.Text = "Le roi grimpe sur la chaise.";
            button8.Tag = "8";
            button8.Text = "Bu kutuda ne var ?";
            button9.Tag = "9";
            button9.Text = "Kral bir banyo alir.";
            button10.Tag = "10";
            button10.Text = "Le roi s'installe à table.";
            button11.Tag = "11";
            button11.Text = "Kral pijama giyer.";
            button12.Tag = "12";
            button12.Text = "Le roi fait une pause.";

            //sons pour les boutons
            sons.Add(items.roiRentreAuChateauFR);
            sons.Add(items.roiVaALecoleTurc);
            sons.Add(items.roiTraverseLaForetFR);
            sons.Add(items.roiTraverseLeJardinTurc);
            sons.Add(items.roiMonteEscalierFR);
            sons.Add(items.roiMonteLitTurc);
            sons.Add(items.roiMonteChaiseFR);
            sons.Add(items.questionBoiteTurc);
            sons.Add(items.roiPrendBainTurc);
            sons.Add(items.roiSInstalleTableFR);
            sons.Add(items.roiMetPijamaTurc);
            sons.Add(items.roiPrendPauseFR);

            //sons pour les images
            sons.Add(items.chateauFR);
            sons.Add(items.ecoleTurc);
            sons.Add(items.foretFR);
            sons.Add(items.jardinTurc);
            sons.Add(items.escalierFR);
            sons.Add(items.litTurc);
            sons.Add(items.chaiseFR);
            sons.Add(items.coffreTurc);
            sons.Add(items.bainTurc);
            sons.Add(items.tableFR);
            sons.Add(items.pijama);
            sons.Add(items.pauseFR);

            //picturebox
            this.pictureBox1.Image = items.chateau1;
            this.pictureBox2.Image = items.ecole1;
            this.pictureBox3.Image = items.foret1;
            this.pictureBox4.Image = items.jardin1;
            this.pictureBox12.Image = items.escalier1;
            this.pictureBox13.Image = items.lit1;
            this.pictureBox14.Image = items.chaise1;
            this.pictureBox16.Image = items.coffre1;
            this.pictureBox24.Image = items.bain1;
            this.pictureBox23.Image = items.table1;
            this.pictureBox22.Image = items.pijama1;
            this.pictureBox21.Image = items.pause1;
        }
        
        
    }
}
