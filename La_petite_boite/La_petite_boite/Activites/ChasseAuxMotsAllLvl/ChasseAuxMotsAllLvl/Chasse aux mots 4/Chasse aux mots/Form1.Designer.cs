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
            
            // ChasseAuxMots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(new ChasseAuxMotsPanel());
            this.Name = "ChasseAuxMots";
            this.Text = "ChasseAuxMots";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
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

        public void initialize()
        {
            this.conteneurCarte = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ecouter = new System.Windows.Forms.Button();
            this.Resultat = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
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
            this.conteneurCarte.Location = new System.Drawing.Point(153, 99);
            this.conteneurCarte.Name = "conteneurCarte";
            this.conteneurCarte.Size = new System.Drawing.Size(610, 197);
            this.conteneurCarte.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(463, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 160);
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
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            this.pictureBox1.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // Ecouter
            // 
            this.Ecouter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Ecouter.FlatAppearance.BorderSize = 0;
            this.Ecouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ecouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ecouter.Location = new System.Drawing.Point(365, 343);
            this.Ecouter.Name = "Ecouter";
            this.Ecouter.Size = new System.Drawing.Size(198, 51);
            this.Ecouter.TabIndex = 1;
            this.Ecouter.Text = "Ecouter";
            this.Ecouter.UseVisualStyleBackColor = false;
            this.Ecouter.Click += new System.EventHandler(this.Ecouter_Click);
            // 
            // Resultat
            // 
            this.Resultat.AutoSize = true;
            this.Resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultat.Location = new System.Drawing.Point(12, 149);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(75, 24);
            this.Resultat.TabIndex = 2;
            this.Resultat.Text = "Score : ";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(96, 149);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(0, 24);
            this.Score.TabIndex = 3;
            // 
            // 
            // ChasseAuxMots
            // 
            this.ClientSize = new System.Drawing.Size(999, 528);
            this.Location = new System.Drawing.Point(125, 100);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.Ecouter);
            this.Controls.Add(this.conteneurCarte);
            this.Name = "ChasseAuxMots";
            this.Text = "ChasseAuxMots";
            this.conteneurCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

