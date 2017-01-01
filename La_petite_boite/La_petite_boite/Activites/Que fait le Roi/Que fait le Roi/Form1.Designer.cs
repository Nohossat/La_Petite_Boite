using System.Windows.Forms;

namespace Que_fait_le_Roi
{
    partial class QueFaitLeRoi
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "QueFaitleRoi4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "QueFaitleRoi8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(587, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "QueFaitleRoi12";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // QueFaitLeRoi
            // 
            this.ClientSize = new System.Drawing.Size(1274, 700);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "QueFaitLeRoi";
            this.ResumeLayout(false);

        }

        private Button button1;
        private Button button2;
        private Button button3;
    }

    #endregion

    partial class QueFaitLeRoi4Panel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void initialize()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueFaitLeRoi));
            
            this.conteneurCarte = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.conteneurBouton = new System.Windows.Forms.Panel();
            this.conteneurCarteAPlacer = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();


            this.conteneurCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.conteneurBouton.SuspendLayout();
            this.conteneurCarteAPlacer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();

            // conteneurBouton
            // 
            this.conteneurBouton.Controls.Add(this.button1);
            this.conteneurBouton.Controls.Add(this.button2);
            this.conteneurBouton.Controls.Add(this.button3);
            this.conteneurBouton.Controls.Add(this.button4);
            this.conteneurBouton.Location = new System.Drawing.Point(10, 5);
            this.conteneurBouton.Name = "conteneurBouton";
            this.conteneurBouton.Size = new System.Drawing.Size(690, 44);
            // 
            // conteneurCarte
            // 
            this.conteneurCarte.Controls.Add(this.pictureBox1);
            this.conteneurCarte.Controls.Add(this.pictureBox2);
            this.conteneurCarte.Controls.Add(this.pictureBox3);
            this.conteneurCarte.Controls.Add(this.pictureBox4);
            this.conteneurCarte.Location = new System.Drawing.Point(10, 275);
            this.conteneurCarte.Name = "conteneurCarte";
            this.conteneurCarte.Size = new System.Drawing.Size(690, 167);
            // 

            // conteneurCarteAPlacer
            // 
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox5);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox6);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox7);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox8);
            this.conteneurCarteAPlacer.Location = new System.Drawing.Point(10, 55);
            this.conteneurCarteAPlacer.Name = "conteneurCarteAPlacer";
            this.conteneurCarteAPlacer.Size = new System.Drawing.Size(690, 167);

            // Cartes
            // 
            this.pictureBox4.Tag = "4";
            this.pictureBox1.Tag = "1";
            this.pictureBox2.Tag = "2";
            this.pictureBox3.Tag = "3";
            // 
            // Emplacements
            // 
            this.pictureBox5.Tag = "1";
            this.pictureBox6.Tag = "2";
            this.pictureBox7.Tag = "3";
            this.pictureBox8.Tag = "4";
            // 

            // QueFaitLeRoiPanel
            this.ClientSize = new System.Drawing.Size(720, 472);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "QueFaitLeRoi";
            this.conteneurCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.conteneurBouton.ResumeLayout(false);
            this.conteneurCarteAPlacer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

    partial class QueFaitLeRoi8Panel
    {

        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void initialize()
        {
            this.conteneurBouton = new System.Windows.Forms.Panel();
            this.conteneurCarteAPlacer = new System.Windows.Forms.Panel();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.conteneurCarte = new System.Windows.Forms.Panel();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.conteneurBouton.SuspendLayout();
            this.conteneurCarteAPlacer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.conteneurCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // 
            // conteneurBouton
            // 
            this.conteneurBouton.Controls.Add(this.button8);
            this.conteneurBouton.Controls.Add(this.button7);
            this.conteneurBouton.Controls.Add(this.button6);
            this.conteneurBouton.Controls.Add(this.button5);
            this.conteneurBouton.Controls.Add(this.button1);
            this.conteneurBouton.Controls.Add(this.button2);
            this.conteneurBouton.Controls.Add(this.button3);
            this.conteneurBouton.Controls.Add(this.button4);
            this.conteneurBouton.Location = new System.Drawing.Point(10, 12);
            this.conteneurBouton.Name = "conteneurBouton";
            this.conteneurBouton.Size = new System.Drawing.Size(1090, 44);
            // 
            // 
            // conteneurCarteAPlacer
            // 
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox15);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox11);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox10);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox9);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox5);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox6);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox7);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox8);
            this.conteneurCarteAPlacer.Location = new System.Drawing.Point(10, 82);
            this.conteneurCarteAPlacer.Name = "conteneurCarteAPlacer";
            this.conteneurCarteAPlacer.Size = new System.Drawing.Size(1090, 168);
            // 
            // conteneurCarte
            // 
            this.conteneurCarte.Controls.Add(this.pictureBox1);
            this.conteneurCarte.Controls.Add(this.pictureBox2);
            this.conteneurCarte.Controls.Add(this.pictureBox3);
            this.conteneurCarte.Controls.Add(this.pictureBox4);
            this.conteneurCarte.Controls.Add(this.pictureBox12);
            this.conteneurCarte.Controls.Add(this.pictureBox13);
            this.conteneurCarte.Controls.Add(this.pictureBox14);
            this.conteneurCarte.Controls.Add(this.pictureBox16);
            this.conteneurCarte.Location = new System.Drawing.Point(10, 302);
            this.conteneurCarte.Name = "conteneurCarte";
            this.conteneurCarte.Size = new System.Drawing.Size(1090, 167);

            // Emplacements
            this.pictureBox15.Tag = "8";
            this.pictureBox11.Tag = "7";
            this.pictureBox10.Tag = "6";
            this.pictureBox9.Tag = "5";
            this.pictureBox5.Tag = "1";
            this.pictureBox6.Tag = "2";
            this.pictureBox7.Tag = "3";
            this.pictureBox8.Tag = "4";
            
            //Cartes
            this.pictureBox16.Tag = "8";
            this.pictureBox14.Tag = "7";
            this.pictureBox13.Tag = "6";
            this.pictureBox12.Tag = "5";
            this.pictureBox4.Tag = "4";
            this.pictureBox3.Tag = "3";
            this.pictureBox2.Tag = "2";
            this.pictureBox1.Tag = "1";

            // queFaitLeRoi8Panel 
            // 
            this.ClientSize = new System.Drawing.Size(1120, 500);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "queFaitLeRoi8";
            this.conteneurBouton.ResumeLayout(false);
            this.conteneurCarteAPlacer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.conteneurCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

    partial class QueFaitLeRoi12Panel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void initialize()
        {
            this.conteneurCarteAPlacer = new System.Windows.Forms.Panel();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.conteneurCarte = new System.Windows.Forms.Panel();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.conteneurBouton = new System.Windows.Forms.Panel();
            this.conteneurCarteAPlacer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.conteneurCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.conteneurBouton.SuspendLayout();
            this.SuspendLayout();
            // 
            // conteneurCarteAPlacer
            // 
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox18);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox19);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox20);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox17);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox15);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox11);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox10);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox9);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox5);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox6);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox7);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox8);
            this.conteneurCarteAPlacer.Location = new System.Drawing.Point(5, 96);
            this.conteneurCarteAPlacer.Name = "conteneurCarteAPlacer";
            this.conteneurCarteAPlacer.Size = new System.Drawing.Size(1240, 142);

            // conteneurCarte
            // 
            this.conteneurCarte.Controls.Add(this.pictureBox1);
            this.conteneurCarte.Controls.Add(this.pictureBox2);
            this.conteneurCarte.Controls.Add(this.pictureBox3);
            this.conteneurCarte.Controls.Add(this.pictureBox4);
            this.conteneurCarte.Controls.Add(this.pictureBox12);
            this.conteneurCarte.Controls.Add(this.pictureBox13);
            this.conteneurCarte.Controls.Add(this.pictureBox14);
            this.conteneurCarte.Controls.Add(this.pictureBox16);
            this.conteneurCarte.Controls.Add(this.pictureBox24);
            this.conteneurCarte.Controls.Add(this.pictureBox23);
            this.conteneurCarte.Controls.Add(this.pictureBox22);
            this.conteneurCarte.Controls.Add(this.pictureBox21);
            this.conteneurCarte.Location = new System.Drawing.Point(5, 255);
            this.conteneurCarte.Name = "conteneurCarte";
            this.conteneurCarte.Size = new System.Drawing.Size(1240, 139);

            // conteneurBouton
            // 
            this.conteneurBouton.Controls.Add(this.button12);
            this.conteneurBouton.Controls.Add(this.button11);
            this.conteneurBouton.Controls.Add(this.button10);
            this.conteneurBouton.Controls.Add(this.button9);
            this.conteneurBouton.Controls.Add(this.button8);
            this.conteneurBouton.Controls.Add(this.button7);
            this.conteneurBouton.Controls.Add(this.button6);
            this.conteneurBouton.Controls.Add(this.button5);
            this.conteneurBouton.Controls.Add(this.button1);
            this.conteneurBouton.Controls.Add(this.button2);
            this.conteneurBouton.Controls.Add(this.button3);
            this.conteneurBouton.Controls.Add(this.button4);
            this.conteneurBouton.Location = new System.Drawing.Point(5, 25);
            this.conteneurBouton.Name = "conteneurBouton";
            this.conteneurBouton.Size = new System.Drawing.Size(1240, 44);
            // 
            // 
            //Emplacements
            // 
            this.pictureBox18.Tag = "12";
            this.pictureBox19.Tag = "11";
            this.pictureBox20.Tag = "10";
            this.pictureBox17.Tag = "9";
            this.pictureBox15.Tag = "8";
            this.pictureBox11.Tag = "7";
            this.pictureBox10.Tag = "6";
            this.pictureBox9.Tag = "5";
            this.pictureBox5.Tag = "1";
            this.pictureBox6.Tag = "2";
            this.pictureBox7.Tag = "3";
            this.pictureBox8.Tag = "4";
            // 
            // 
            ////Cartes
            // 
            this.pictureBox21.Tag = "12";
            this.pictureBox22.Tag = "11";
            this.pictureBox23.Tag = "10";
            this.pictureBox24.Tag = "9";
            this.pictureBox16.Tag = "8";
            this.pictureBox14.Tag = "7";
            this.pictureBox13.Tag = "6";
            this.pictureBox12.Tag = "5";
            this.pictureBox4.Tag = "4";
            this.pictureBox3.Tag = "3";
            this.pictureBox2.Tag = "2";
            this.pictureBox1.Tag = "1";

            // Que fait le roi 12
            // 
            this.ClientSize = new System.Drawing.Size(1270, 430);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Que fait le roi ?";
            this.Text = "";
            this.conteneurCarteAPlacer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.conteneurCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.conteneurBouton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}

