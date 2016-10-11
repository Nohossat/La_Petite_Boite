namespace memory8Cartes
{
    partial class Memory8
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score";
            // 
            // Memory8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 441);
            this.Controls.Add(this.label1);
            this.Name = "Memory8";
            this.Text = "Jeu Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        
    }

    partial class MemoryPanel
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
            this.doubleCarte4 = new System.Windows.Forms.PictureBox();
            this.carte4 = new System.Windows.Forms.PictureBox();
            this.doubleCarte3 = new System.Windows.Forms.PictureBox();
            this.carte3 = new System.Windows.Forms.PictureBox();
            this.doubleCarte2 = new System.Windows.Forms.PictureBox();
            this.carte2 = new System.Windows.Forms.PictureBox();
            this.doubleCarte1 = new System.Windows.Forms.PictureBox();
            this.carte1 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.conteneurCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleCarte4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleCarte3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleCarte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleCarte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneurCarte
            // 
            this.conteneurCarte.Controls.Add(this.doubleCarte4);
            this.conteneurCarte.Controls.Add(this.carte4);
            this.conteneurCarte.Controls.Add(this.doubleCarte3);
            this.conteneurCarte.Controls.Add(this.carte3);
            this.conteneurCarte.Controls.Add(this.doubleCarte2);
            this.conteneurCarte.Controls.Add(this.carte2);
            this.conteneurCarte.Controls.Add(this.doubleCarte1);
            this.conteneurCarte.Controls.Add(this.carte1);
            this.conteneurCarte.Location = new System.Drawing.Point(147, 100);
            this.conteneurCarte.Name = "conteneurCarte";
            this.conteneurCarte.Size = new System.Drawing.Size(628, 379);
            this.conteneurCarte.TabIndex = 0;
            // 
            // doubleCarte4
            // 
            this.doubleCarte4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doubleCarte4.Location = new System.Drawing.Point(475, 194);
            this.doubleCarte4.Name = "doubleCarte4";
            this.doubleCarte4.Size = new System.Drawing.Size(130, 160);
            this.doubleCarte4.TabIndex = 15;
            this.doubleCarte4.TabStop = false;
            this.doubleCarte4.Tag = "4";
            this.doubleCarte4.Click += new System.EventHandler(this.jouer);
            // 
            // carte4
            // 
            this.carte4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carte4.Location = new System.Drawing.Point(321, 194);
            this.carte4.Name = "carte4";
            this.carte4.Size = new System.Drawing.Size(130, 160);
            this.carte4.TabIndex = 14;
            this.carte4.TabStop = false;
            this.carte4.Tag = "4";
            this.carte4.Click += new System.EventHandler(this.jouer);
            // 
            // doubleCarte3
            // 
            this.doubleCarte3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doubleCarte3.Location = new System.Drawing.Point(167, 194);
            this.doubleCarte3.Name = "doubleCarte3";
            this.doubleCarte3.Size = new System.Drawing.Size(130, 160);
            this.doubleCarte3.TabIndex = 13;
            this.doubleCarte3.TabStop = false;
            this.doubleCarte3.Tag = "3";
            this.doubleCarte3.Click += new System.EventHandler(this.jouer);
            // 
            // carte3
            // 
            this.carte3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carte3.Location = new System.Drawing.Point(14, 194);
            this.carte3.Name = "carte3";
            this.carte3.Size = new System.Drawing.Size(130, 160);
            this.carte3.TabIndex = 12;
            this.carte3.TabStop = false;
            this.carte3.Tag = "3";
            this.carte3.Click += new System.EventHandler(this.jouer);
            // 
            // doubleCarte2
            // 
            this.doubleCarte2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doubleCarte2.Location = new System.Drawing.Point(476, 15);
            this.doubleCarte2.Name = "doubleCarte2";
            this.doubleCarte2.Size = new System.Drawing.Size(130, 160);
            this.doubleCarte2.TabIndex = 11;
            this.doubleCarte2.TabStop = false;
            this.doubleCarte2.Tag = "2";
            this.doubleCarte2.Click += new System.EventHandler(this.jouer);
            // 
            // carte2
            // 
            this.carte2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carte2.Location = new System.Drawing.Point(320, 15);
            this.carte2.Name = "carte2";
            this.carte2.Size = new System.Drawing.Size(130, 160);
            this.carte2.TabIndex = 10;
            this.carte2.TabStop = false;
            this.carte2.Tag = "2";
            this.carte2.Click += new System.EventHandler(this.jouer);
            // 
            // doubleCarte1
            // 
            this.doubleCarte1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doubleCarte1.Location = new System.Drawing.Point(167, 15);
            this.doubleCarte1.Name = "doubleCarte1";
            this.doubleCarte1.Size = new System.Drawing.Size(130, 160);
            this.doubleCarte1.TabIndex = 9;
            this.doubleCarte1.TabStop = false;
            this.doubleCarte1.Tag = "1";
            this.doubleCarte1.Click += new System.EventHandler(this.jouer);
            // 
            // carte1
            // 
            this.carte1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carte1.Location = new System.Drawing.Point(14, 15);
            this.carte1.Name = "carte1";
            this.carte1.Size = new System.Drawing.Size(130, 160);
            this.carte1.TabIndex = 8;
            this.carte1.TabStop = false;
            this.carte1.Tag = "1";
            this.carte1.Click += new System.EventHandler(this.jouer);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(69, 113);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(0, 24);
            this.Score.TabIndex = 1;
            // 
            // MemoryPanel
            // 
            this.ClientSize = new System.Drawing.Size(999, 528);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.conteneurCarte);
            this.Name = "Memory8";
            this.Text = "Jeu Memory";
            this.conteneurCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doubleCarte4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleCarte3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleCarte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleCarte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1)).EndInit();
        }
    }
}

