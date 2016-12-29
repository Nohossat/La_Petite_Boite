using System.Drawing;
using System.Windows.Forms;

namespace Chasse_aux_mots
{
    partial class ChasseAuxMots
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
            this.button1.Location = new System.Drawing.Point(110, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "12";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ChasseAuxMots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 700);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ChasseAuxMots";
            this.Text = "ChasseAuxMots";
            this.ResumeLayout(false);

        }


        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }

    partial class ChasseAuxMotsPanel
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

        public void initializeChasseAuxMots4()
        {
            this.conteneurCarte = new Panel();
            this.pictureBox4 = new PictureBox();
            this.pictureBox3 = new PictureBox();
            this.pictureBox2 = new PictureBox();
            this.pictureBox1 = new PictureBox();
            this.Ecouter = new Button();
            this.conteneurCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneurCarte
            // 
            this.conteneurCarte.Controls.Add(this.pictureBox4);
            this.conteneurCarte.Controls.Add(this.pictureBox3);
            this.conteneurCarte.Controls.Add(this.pictureBox2);
            this.conteneurCarte.Controls.Add(this.pictureBox1);
            this.conteneurCarte.Size = new Size(600, 197);
            
            // 
            // pictureBox4
            // 
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Tag = "4";
            
            // 
            // pictureBox3
            // 
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Tag = "3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Tag = "2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Tag = "1";
            // 
            // Ecouter
            // 
            this.Ecouter.Location = new Point(200, 210);
            this.Ecouter.Click += new System.EventHandler(this.Ecouter_Click);
            // 
            // 
            // ChasseAuxMots
            // 
            this.ClientSize = new Size(600, 290);
            this.conteneurCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        
    }

    partial class ChasseAuxMots8Panel
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
        

        public void initializeChasseAuxMots8()
        {
            this.Ecouter = new System.Windows.Forms.Button();
            this.conteneurCarte = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conteneurCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Rejouer
            // 
            // Ecouter
            // 
            this.Ecouter.Location = new System.Drawing.Point(200, 380);
            this.Ecouter.Click += new System.EventHandler(this.Ecouter_Click);
            // 
            // conteneurCarte
            // 
            this.conteneurCarte.Controls.Add(this.pictureBox8);
            this.conteneurCarte.Controls.Add(this.pictureBox7);
            this.conteneurCarte.Controls.Add(this.pictureBox6);
            this.conteneurCarte.Controls.Add(this.pictureBox5);
            this.conteneurCarte.Controls.Add(this.pictureBox4);
            this.conteneurCarte.Controls.Add(this.pictureBox3);
            this.conteneurCarte.Controls.Add(this.pictureBox2);
            this.conteneurCarte.Controls.Add(this.pictureBox1);
            this.conteneurCarte.Size = new System.Drawing.Size(590, 348);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Tag = "8";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Tag = "7";

            // 
            // pictureBox6
            // 
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Tag = "6";

            // 
            // pictureBox5
            // 
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Tag = "5";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Tag = "4";

            // 
            // pictureBox3
            // 
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Tag = "3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Tag = "2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Tag = "1";
            // 
            // ChasseAuxMots8Panel
            // 
            this.ClientSize = new System.Drawing.Size(605, 470);
            this.conteneurCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

    partial class ChasseAuxMots12Panel
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
            this.Ecouter = new System.Windows.Forms.Button();
            this.conteneurCarte = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conteneurCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            //
            // 
            // Ecouter
            // 
            this.Ecouter.Location = new System.Drawing.Point(360, 380);
            this.Ecouter.Click += new System.EventHandler(this.Ecouter_Click);
            // 
            // conteneurCarte
            // 
            this.conteneurCarte.Controls.Add(this.pictureBox12);
            this.conteneurCarte.Controls.Add(this.pictureBox11);
            this.conteneurCarte.Controls.Add(this.pictureBox10);
            this.conteneurCarte.Controls.Add(this.pictureBox9);
            this.conteneurCarte.Controls.Add(this.pictureBox8);
            this.conteneurCarte.Controls.Add(this.pictureBox7);
            this.conteneurCarte.Controls.Add(this.pictureBox6);
            this.conteneurCarte.Controls.Add(this.pictureBox5);
            this.conteneurCarte.Controls.Add(this.pictureBox4);
            this.conteneurCarte.Controls.Add(this.pictureBox3);
            this.conteneurCarte.Controls.Add(this.pictureBox2);
            this.conteneurCarte.Controls.Add(this.pictureBox1);
            this.conteneurCarte.Size = new System.Drawing.Size(870, 380);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Tag = "12";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Tag = "11";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Tag = "10";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Tag = "9";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Tag = "8";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Tag = "7";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Tag = "6";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Tag = "5";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Tag = "4";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Tag = "3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Tag = "2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Tag = "1";
            // 
            // ChasseAuxMots12Panel
            // 
            this.ClientSize = new Size(905, 470);
            this.conteneurCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

