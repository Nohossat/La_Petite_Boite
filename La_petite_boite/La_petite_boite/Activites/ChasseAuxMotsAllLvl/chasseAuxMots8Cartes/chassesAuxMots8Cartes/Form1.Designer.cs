﻿using System.Windows.Forms;

namespace chassesAuxMots8Cartes
{
    partial class ChasseAuxMots8
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
            
            // 
            // ChasseAuxMots8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 529);
            this.Controls.Add(new ChasseAuxMots8Panel());
            this.Name = "ChasseAuxMots8";
            this.Text = "ChasseAuxMots8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
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

        public void initialize()
        {
            this.Score = new System.Windows.Forms.Label();
            this.Resultat = new System.Windows.Forms.Label();
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
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(98, 159);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(0, 24);
            this.Score.TabIndex = 8;
            // 
            // Resultat
            // 
            this.Resultat.AutoSize = true;
            this.Resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultat.Location = new System.Drawing.Point(8, 159);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(75, 24);
            this.Resultat.TabIndex = 7;
            this.Resultat.Text = "Score : ";
            // 
            // Ecouter
            // 
            this.Ecouter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Ecouter.FlatAppearance.BorderSize = 0;
            this.Ecouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ecouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ecouter.Location = new System.Drawing.Point(345, 442);
            this.Ecouter.Name = "Ecouter";
            this.Ecouter.Size = new System.Drawing.Size(198, 51);
            this.Ecouter.TabIndex = 6;
            this.Ecouter.Text = "Ecouter";
            this.Ecouter.UseVisualStyleBackColor = false;
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
            this.conteneurCarte.Location = new System.Drawing.Point(138, 35);
            this.conteneurCarte.Name = "conteneurCarte";
            this.conteneurCarte.Size = new System.Drawing.Size(610, 371);
            this.conteneurCarte.TabIndex = 5;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(463, 195);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(130, 160);
            this.pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "8";
            this.pictureBox8.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(313, 195);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(130, 160);
            this.pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "7";
            this.pictureBox7.Click += new System.EventHandler(this.CliquerReponse);

            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(163, 195);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(130, 160);
            this.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "6";
            this.pictureBox6.Click += new System.EventHandler(this.CliquerReponse);

            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(16, 195);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 160);
            this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "5";
            this.pictureBox5.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(463, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 160);
            this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "4";
            this.pictureBox4.Click += new System.EventHandler(this.CliquerReponse);

            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(313, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 160);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "3";
            this.pictureBox3.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(163, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 160);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "2";
            this.pictureBox2.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 160);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            this.pictureBox1.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // ChasseAuxMots8Panel
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Location = new System.Drawing.Point(60, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.Ecouter);
            this.Controls.Add(this.conteneurCarte);
            this.Name = "ChasseAuxMots8";
            this.Text = "ChasseAuxMots8";
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
}

