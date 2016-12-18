using System.Windows.Forms;

namespace Grand_ou_Petit
{
    partial class Form1
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
            this.button1.Location = new System.Drawing.Point(116, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "4 cartes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "8 cartes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(506, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "12 cartes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 700);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Petit ou Grand ?";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }

    partial class GrandOuPetit
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
            this.conteneurGrandeCarte = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conteneurCarteAPlacer = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.conteneurPetiteCarte = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.conteneurGrandeCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.conteneurCarteAPlacer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.conteneurPetiteCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneurGrandeCarte
            // 
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox1);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox2);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox3);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox4);
            this.conteneurGrandeCarte.Location = new System.Drawing.Point(0, 12);
            this.conteneurGrandeCarte.Name = "conteneurGrandeCarte";
            this.conteneurGrandeCarte.Size = new System.Drawing.Size(576, 165);
            this.conteneurGrandeCarte.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.Tag = "4";
            
            // 
            // pictureBox3
            // 
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.Tag = "3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.Tag = "2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.Tag = "1";
            // 
            // 
            // conteneurCarteAPlacer
            // 
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox5);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox6);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox7);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox8);
            this.conteneurCarteAPlacer.Location = new System.Drawing.Point(0, 178);
            this.conteneurCarteAPlacer.Name = "conteneurCarteAPlacer";
            this.conteneurCarteAPlacer.Size = new System.Drawing.Size(576, 165);
            this.conteneurCarteAPlacer.TabIndex = 4;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.Tag = "4";
            
            // 
            // pictureBox7
            // 
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.Tag = "3";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.Tag = "2";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.Tag = "1";
            // 
            // conteneurPetiteCarte
            // 
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox12);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox11);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox10);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox9);
            this.conteneurPetiteCarte.Location = new System.Drawing.Point(0, 347);
            this.conteneurPetiteCarte.Name = "conteneurPetiteCarte";
            this.conteneurPetiteCarte.Size = new System.Drawing.Size(576, 170);
            this.conteneurPetiteCarte.TabIndex = 5;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.Tag = "1";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.TabIndex = 22;
            this.pictureBox11.Tag = "2";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.Tag = "3";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.Tag = "4";
            // 
            // GrandOuPetitPanel
            // 
            this.ClientSize = new System.Drawing.Size(580, 560);
            this.Location = new System.Drawing.Point(0, 0);
            this.Controls.Add(this.conteneurPetiteCarte);
            this.Controls.Add(this.conteneurCarteAPlacer);
            this.Controls.Add(this.conteneurGrandeCarte);
            this.Name = "GrandOuPetit";
            this.Text = "Petit ou Grand ?";
            this.conteneurGrandeCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.conteneurCarteAPlacer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.conteneurPetiteCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

    partial class GrandOuPetit8Panel
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
            this.conteneurPetiteCarte = new System.Windows.Forms.Panel();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.conteneurCarteAPlacer = new System.Windows.Forms.Panel();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.conteneurGrandeCarte = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conteneurPetiteCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.conteneurCarteAPlacer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.conteneurGrandeCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneurPetiteCarte
            // 
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox17);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox18);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox19);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox20);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox21);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox22);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox23);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox24);
            this.conteneurPetiteCarte.Location = new System.Drawing.Point(0, 360);
            this.conteneurPetiteCarte.Name = "conteneurPetiteCarte";
            this.conteneurPetiteCarte.Size = new System.Drawing.Size(1135, 167);
            this.conteneurPetiteCarte.TabIndex = 9;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Location = new System.Drawing.Point(1029, 3);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.TabIndex = 35;
            this.pictureBox24.Tag = "8";
            // 
            // pictureBox23
            // 
            this.pictureBox23.Location = new System.Drawing.Point(880, 3);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.TabIndex = 34;
            this.pictureBox23.Tag = "7";
            // 
            // pictureBox22
            // 
            this.pictureBox22.Location = new System.Drawing.Point(734, 4);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.TabIndex = 33;
            this.pictureBox22.Tag = "6";
            // 
            // pictureBox21
            // 
            this.pictureBox21.Location = new System.Drawing.Point(588, 3);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.TabIndex = 32;
            this.pictureBox21.Tag = "5";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(441, 3);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.TabIndex = 31;
            this.pictureBox20.Tag = "4";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(294, 3);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.TabIndex = 30;
            this.pictureBox19.Tag = "3";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Location = new System.Drawing.Point(148, 3);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.TabIndex = 29;
            this.pictureBox18.Tag = "2";
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(3, 3);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.TabIndex = 28;
            this.pictureBox17.Tag = "1";
            // 

            // conteneurCarteAPlacer
            // 
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox9);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox10);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox11);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox12);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox13);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox14);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox15);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox16);
            this.conteneurCarteAPlacer.Location = new System.Drawing.Point(0, 185);
            this.conteneurCarteAPlacer.Name = "conteneurCarteAPlacer";
            this.conteneurCarteAPlacer.Size = new System.Drawing.Size(1135, 169);
            this.conteneurCarteAPlacer.TabIndex = 8;

            //emplacements carte
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(441, 6);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.Tag = "4";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(294, 6);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.TabIndex = 22;
            this.pictureBox11.Tag = "3";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(148, 6);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.Tag = "2";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(3, 6);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.Tag = "1";
            // 

            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(734, 6);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.TabIndex = 25;
            this.pictureBox14.Tag = "6";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(588, 6);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.TabIndex = 24;
            this.pictureBox13.Tag = "5";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(1029, 6);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.TabIndex = 27;
            this.pictureBox16.Tag = "8";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(880, 6);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.TabIndex = 26;
            this.pictureBox15.Tag = "7";
            // 

            // conteneurGrandeCarte
            // 
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox1);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox2);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox3);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox4);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox5);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox6);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox7);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox8);
            this.conteneurGrandeCarte.Location = new System.Drawing.Point(0, 9);
            this.conteneurGrandeCarte.Name = "conteneurGrandeCarte";
            this.conteneurGrandeCarte.Size = new System.Drawing.Size(1135, 170);
            this.conteneurGrandeCarte.TabIndex = 6;
            //grandes cartes
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(1029, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.Tag = "8";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(880, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.Tag = "7";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(734, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.Tag = "6";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(588, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.Tag = "5";
            // 
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(441, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.Tag = "4";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(294, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.Tag = "3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(148, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 160);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.Tag = "1";
            // GrandOuPetit8
            // 
            this.ClientSize = new System.Drawing.Size(1140, 527);
            this.Location = new System.Drawing.Point(0, 0);
            this.Controls.Add(this.conteneurPetiteCarte);
            this.Controls.Add(this.conteneurCarteAPlacer);
            this.Controls.Add(this.conteneurGrandeCarte);
            this.Name = "GrandOuPetit8";
            this.Text = "GrandOuPetit8";
            this.conteneurPetiteCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.conteneurCarteAPlacer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.conteneurGrandeCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

    partial class GrandOuPetit12Panel
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


        private void initialize()
        {
            this.conteneurPetiteCarte = new System.Windows.Forms.Panel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.conteneurCarteAPlacer = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.conteneurGrandeCarte = new System.Windows.Forms.Panel();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conteneurPetiteCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            this.conteneurCarteAPlacer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            this.conteneurGrandeCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // conteneurPetiteCarte
            // 
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox17);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox18);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox19);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox20);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox24);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox22);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox33);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox35);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox21);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox23);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox34);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox36);
            this.conteneurPetiteCarte.Location = new System.Drawing.Point(0, 360);
            this.conteneurPetiteCarte.Name = "conteneurPetiteCarte";
            this.conteneurPetiteCarte.Size = new System.Drawing.Size(1275, 138);
            this.conteneurPetiteCarte.TabIndex = 15;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(1170, 4);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.TabIndex = 31;
            this.pictureBox17.Tag = "1";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Location = new System.Drawing.Point(1064, 4);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.TabIndex = 30;
            this.pictureBox18.Tag = "2";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(958, 4);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.TabIndex = 29;
            this.pictureBox19.Tag = "3";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(852, 4);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.TabIndex = 28;
            this.pictureBox20.Tag = "4";
            // 
            
            // pictureBox24
            // 
            this.pictureBox24.Location = new System.Drawing.Point(746, 4);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.TabIndex = 27;
            this.pictureBox24.Tag = "5";
            // 
            // 
            // pictureBox22
            // 
            this.pictureBox22.Location = new System.Drawing.Point(640, 4);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.TabIndex = 26;
            this.pictureBox22.Tag = "6";

            // pictureBox33
            // 
            this.pictureBox33.Location = new System.Drawing.Point(534, 4);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.TabIndex = 25;
            this.pictureBox33.Tag = "7";
            // 
            // 
            // pictureBox35
            // 
            this.pictureBox35.Location = new System.Drawing.Point(428, 4);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.TabIndex = 24;
            this.pictureBox35.Tag = "8";

            // pictureBox21
            // 
            this.pictureBox21.Location = new System.Drawing.Point(322, 4);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.TabIndex = 23;
            this.pictureBox21.Tag = "9";

            // pictureBox23
            // 
            this.pictureBox23.Location = new System.Drawing.Point(216, 4);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.TabIndex = 22;
            this.pictureBox23.Tag = "10";

            // pictureBox34
            // 
            this.pictureBox34.Location = new System.Drawing.Point(110, 4);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.TabIndex = 21;
            this.pictureBox34.Tag = "11";
            // 
            // pictureBox36
            // 
            this.pictureBox36.Location = new System.Drawing.Point(4, 4);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.TabIndex = 20;
            this.pictureBox36.Tag = "12";
            // 
            // conteneurCarteAPlacer
            // 
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox32);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox30);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox15);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox13);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox31);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox29);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox14);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox16);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox12);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox11);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox10);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox9);
            this.conteneurCarteAPlacer.Location = new System.Drawing.Point(0, 185);
            this.conteneurCarteAPlacer.Name = "conteneurCarteAPlacer";
            this.conteneurCarteAPlacer.Size = new System.Drawing.Size(1275, 144);
            this.conteneurCarteAPlacer.TabIndex = 14;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(1170, 7);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabIndex = 31;
            this.pictureBox9.Tag = "12";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(1064, 7);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.TabIndex = 30;
            this.pictureBox10.Tag = "11";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(958, 7);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.TabIndex = 29;
            this.pictureBox11.Tag = "10";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(852, 7);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.TabIndex = 28;
            this.pictureBox12.Tag = "9";
            // 
           
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(746, 7);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.TabIndex = 27;
            this.pictureBox16.Tag = "8";

            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(640, 7);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.TabIndex = 26;
            this.pictureBox14.Tag = "7";
            // 
            // pictureBox29
            // 
            this.pictureBox29.Location = new System.Drawing.Point(534, 7);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.TabIndex = 25;
            this.pictureBox29.Tag = "6";
            // 
           
            // pictureBox31
            // 
            this.pictureBox31.Location = new System.Drawing.Point(428, 7);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.TabIndex = 24;
            this.pictureBox31.Tag = "5";

            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(322, 7);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.TabIndex = 23;
            this.pictureBox13.Tag = "4";

            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(216, 7);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.TabIndex = 22;
            this.pictureBox15.Tag = "3";
            // 

            // pictureBox30
            // 
            this.pictureBox30.Location = new System.Drawing.Point(110, 7);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.TabIndex = 21;
            this.pictureBox30.Tag = "2";
            // 
            // 
            // pictureBox32
            // 
            this.pictureBox32.Location = new System.Drawing.Point(4, 7);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.TabIndex = 20;
            this.pictureBox32.Tag = "1";
            // 
            // 
            // conteneurGrandeCarte
            // 
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox1);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox2);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox3);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox4);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox5);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox6);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox7);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox8);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox25);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox26);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox27);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox28);
            this.conteneurGrandeCarte.Location = new System.Drawing.Point(0, 9);
            this.conteneurGrandeCarte.Name = "conteneurGrandeCarte";
            this.conteneurGrandeCarte.Size = new System.Drawing.Size(1275, 142);
            this.conteneurGrandeCarte.TabIndex = 12;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Location = new System.Drawing.Point(1169, 3);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.TabIndex = 19;
            this.pictureBox28.Tag = "12";
            // 
            // pictureBox27
            // 
            this.pictureBox27.Location = new System.Drawing.Point(1063, 3);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.TabIndex = 18;
            this.pictureBox27.Tag = "11";
            // 
            // pictureBox26
            // 
            this.pictureBox26.Location = new System.Drawing.Point(957, 3);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.TabIndex = 17;
            this.pictureBox26.Tag = "10";
            // 
            // pictureBox25
            // 
            this.pictureBox25.Location = new System.Drawing.Point(851, 3);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.TabIndex = 16;
            this.pictureBox25.Tag = "9";
            // 
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(745, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.Tag = "8";

            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(639, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.Tag = "7";
            // 
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(533, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.Tag = "6";
            // 
            
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(427, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.Tag = "5";

            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(321, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.Tag = "4";

            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(215, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.Tag = "3";
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(109, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.Tag = "2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.Tag = "1";
            // 
            // PANEL
            // 
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Location = new System.Drawing.Point(0, 140);
            this.Controls.Add(this.conteneurPetiteCarte);
            this.Controls.Add(this.conteneurCarteAPlacer);
            this.Controls.Add(this.conteneurGrandeCarte);
            this.Name = "GrandOuPetit12";
            this.Text = "GrandOuPetit12";
            this.conteneurPetiteCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            this.conteneurCarteAPlacer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            this.conteneurGrandeCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

