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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 555);
            this.Controls.Add(new GrandOuPetit());
            this.Name = "Form1";
            this.Text = "Petit ou Grand ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
            this.label = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
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
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox4);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox3);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox2);
            this.conteneurGrandeCarte.Controls.Add(this.pictureBox1);
            this.conteneurGrandeCarte.Location = new System.Drawing.Point(151, 12);
            this.conteneurGrandeCarte.Name = "conteneurGrandeCarte";
            this.conteneurGrandeCarte.Size = new System.Drawing.Size(576, 170);
            this.conteneurGrandeCarte.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(441, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 160);
            this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "4";
            this.pictureBox4.Click += new System.EventHandler(this.cliquerPremiereLigne);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(294, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 160);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "3";
            this.pictureBox3.Click += new System.EventHandler(this.cliquerPremiereLigne);
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
            this.pictureBox2.Click += new System.EventHandler(this.cliquerPremiereLigne);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 160);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            this.pictureBox1.Click += new System.EventHandler(this.cliquerPremiereLigne);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(28, 214);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 24);
            this.label.TabIndex = 1;
            this.label.Text = "Score :";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(112, 214);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(0, 24);
            this.Score.TabIndex = 2;
            // 
            // 
            // conteneurCarteAPlacer
            // 
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox8);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox7);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox6);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox5);
            this.conteneurCarteAPlacer.Location = new System.Drawing.Point(151, 189);
            this.conteneurCarteAPlacer.Name = "conteneurCarteAPlacer";
            this.conteneurCarteAPlacer.Size = new System.Drawing.Size(576, 169);
            this.conteneurCarteAPlacer.TabIndex = 4;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(441, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(130, 160);
            this.pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "4";
            this.pictureBox8.DragDrop += new System.Windows.Forms.DragEventHandler(this.petiteImage_DragDrop);
            this.pictureBox8.DragEnter += new System.Windows.Forms.DragEventHandler(this.petiteImage_DragEnter);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(294, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(130, 160);
            this.pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "3";
            this.pictureBox7.DragDrop += new System.Windows.Forms.DragEventHandler(this.petiteImage_DragDrop);
            this.pictureBox7.DragEnter += new System.Windows.Forms.DragEventHandler(this.petiteImage_DragEnter);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(148, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(130, 160);
            this.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "2";
            this.pictureBox6.DragDrop += new System.Windows.Forms.DragEventHandler(this.petiteImage_DragDrop);
            this.pictureBox6.DragEnter += new System.Windows.Forms.DragEventHandler(this.petiteImage_DragEnter);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 160);
            this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "1";
            this.pictureBox5.DragDrop += new System.Windows.Forms.DragEventHandler(this.petiteImage_DragDrop);
            this.pictureBox5.DragEnter += new System.Windows.Forms.DragEventHandler(this.petiteImage_DragEnter);
            // 
            // conteneurPetiteCarte
            // 
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox12);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox11);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox10);
            this.conteneurPetiteCarte.Controls.Add(this.pictureBox9);
            this.conteneurPetiteCarte.Location = new System.Drawing.Point(151, 365);
            this.conteneurPetiteCarte.Name = "conteneurPetiteCarte";
            this.conteneurPetiteCarte.Size = new System.Drawing.Size(576, 189);
            this.conteneurPetiteCarte.TabIndex = 5;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(443, 14);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(130, 160);
            this.pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "1";
            this.pictureBox12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.receveurImage_MouseDown);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(294, 14);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(130, 160);
            this.pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 22;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "2";
            this.pictureBox11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.receveurImage_MouseDown);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(148, 14);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(130, 160);
            this.pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "3";
            this.pictureBox10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.receveurImage_MouseDown);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(3, 14);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(130, 160);
            this.pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "4";
            this.pictureBox9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.receveurImage_MouseDown);
            // 
            // GrandOuPetitPanel
            // 
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Location = new System.Drawing.Point(130, 80);
            this.Controls.Add(this.conteneurPetiteCarte);
            this.Controls.Add(this.conteneurCarteAPlacer);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label);
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
}

