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
using System.IO;
using System.Drawing.Text;

namespace Que_fait_le_Roi
{
    public partial class QueFaitLeRoi : Form
    {
        public static List<String> Textes = new List<string>();

        public QueFaitLeRoi()
        {
            InitializeComponent();
            chargementTexte("textesFR.txt", Textes);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //QuefaitleRoi4
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new QueFaitLeRoi4Panel(Textes));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //QuefaitleRoi8
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new QueFaitLeRoi8Panel(Textes));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //QuefaitleRoi12
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new QueFaitLeRoi12Panel(Textes));
        }

        public static void chargementTexte(String nomFichier, List<String> tableauRes)
        {
            try
            {
                using (var reader = new StreamReader(nomFichier, Encoding.GetEncoding("iso-8859-1")))
                {
                    String line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        tableauRes.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write("The file can't be read !" + e);
            }
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
        private bouton button1 = new bouton();
        private bouton button2 = new bouton();
        private bouton button3 = new bouton();
        private bouton button4 = new bouton();


        public QueFaitLeRoi4Panel(List<String> TextesBoutons)
        {
            initialize();
            chargementPartie();
            score = 0;
            finalScore = 4;
            button1.Tag = "1";
            button1.Text = TextesBoutons[74];
            button2.Tag = "2";
            button2.Text = TextesBoutons[75];
            button3.Tag = "3";
            button3.Text = TextesBoutons[76];
            button4.Tag = "4";
            button4.Text = TextesBoutons[77];

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


        public QueFaitLeRoi8Panel(List<String> TextesBoutons)
        {
            initialize();
            chargementPartie();
            score = 0;
            finalScore = 8;
            button1.Tag = "1";
            button1.Text = TextesBoutons[80];
            button2.Tag = "2";
            button2.Text = TextesBoutons[81];
            button3.Tag = "3";
            button3.Text = TextesBoutons[82];
            button4.Tag = "4";
            button4.Text = TextesBoutons[83];
            button5.Tag = "5";
            button5.Text = TextesBoutons[84];
            button6.Tag = "6";
            button6.Text = TextesBoutons[85];
            button7.Tag = "7";
            button7.Text = TextesBoutons[86];
            button8.Tag = "8";
            button8.Text = TextesBoutons[87];

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


        public QueFaitLeRoi12Panel(List<String> TextesBoutons)
        {
            initialize();
            chargementPartie();
            score = 0;
            finalScore = 12;

            button1.Tag = "1";
            button1.Text = TextesBoutons[90];
            button2.Tag = "2";
            button2.Text = TextesBoutons[91];
            button3.Tag = "3";
            button3.Text = TextesBoutons[92];
            button4.Tag = "4";
            button4.Text = TextesBoutons[93];
            button5.Tag = "5";
            button5.Text = TextesBoutons[94];
            button6.Tag = "6";
            button6.Text = TextesBoutons[95];
            button7.Tag = "7";
            button7.Text = TextesBoutons[96];
            button8.Tag = "8";
            button8.Text = TextesBoutons[97];
            button9.Tag = "9";
            button9.Text = TextesBoutons[98];
            button10.Tag = "10";
            button10.Text = TextesBoutons[99];
            button11.Tag = "11";
            button11.Text = TextesBoutons[100];
            button12.Tag = "12";
            button12.Text = TextesBoutons[101];

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

    public class bouton : Button
    {
        public bouton()
        {
            this.UseCompatibleTextRendering = true;
            this.TextRenderingHint = TextRenderingHint.AntiAlias;
            this.FlatAppearance.BorderSize = 0;
            this.TabStop = false;
            this.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            this.ForeColor = Color.White; 
            this.BackColor = ColorTranslator.FromHtml("#b35344");
            this.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#770f00");
            this.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#770f00");
            this.FlatStyle = FlatStyle.Flat;
            this.Dock = DockStyle.None;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Cursor = Cursors.Hand;
            this.GotFocus += new EventHandler(myBtn_GotFocus);
            this.LostFocus += new EventHandler(myBtn_LostFocus);
        }

        private TextRenderingHint _textRenderingHint = TextRenderingHint.SystemDefault;

        public TextRenderingHint TextRenderingHint
        {
            get { return _textRenderingHint; }
            set { _textRenderingHint = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = _textRenderingHint;
            base.OnPaint(e);
        }

        private void myBtn_GotFocus(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = ColorTranslator.FromHtml("#770f00");
        }

        private void myBtn_LostFocus(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = ColorTranslator.FromHtml("#b35344");
        }

    }
}
