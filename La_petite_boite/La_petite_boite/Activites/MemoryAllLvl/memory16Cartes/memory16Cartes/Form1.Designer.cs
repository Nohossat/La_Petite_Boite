using System.Windows.Forms;

namespace memory16Cartes
{
    partial class Memory16
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
            // Memory16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 528);
            this.Controls.Add(new Memory16Panel());
            this.Name = "Memory16";
            this.Text = "Memory16";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }

    partial class Memory16Panel
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

            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.conteneurCarte = new System.Windows.Forms.Panel();
            this.carte9Double = new System.Windows.Forms.PictureBox();
            this.carte9 = new System.Windows.Forms.PictureBox();
            this.carte8double = new System.Windows.Forms.PictureBox();
            this.carte8 = new System.Windows.Forms.PictureBox();
            this.carte7Double = new System.Windows.Forms.PictureBox();
            this.carte7 = new System.Windows.Forms.PictureBox();
            this.carte6Double = new System.Windows.Forms.PictureBox();
            this.carte6 = new System.Windows.Forms.PictureBox();
            this.carte5Double = new System.Windows.Forms.PictureBox();
            this.carte5 = new System.Windows.Forms.PictureBox();
            this.carte4Double = new System.Windows.Forms.PictureBox();
            this.carte4 = new System.Windows.Forms.PictureBox();
            this.carte3Double = new System.Windows.Forms.PictureBox();
            this.carte3 = new System.Windows.Forms.PictureBox();
            this.carte2Double = new System.Windows.Forms.PictureBox();
            this.carte2 = new System.Windows.Forms.PictureBox();
            this.carte1Double = new System.Windows.Forms.PictureBox();
            this.carte1 = new System.Windows.Forms.PictureBox();
            this.conteneurCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carte9Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte8double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte7Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte6Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte5Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte4Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(30, 220);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(0, 20);
            this.Score.TabIndex = 1;
            // 
            // conteneurCarte
            // 
            this.conteneurCarte.Controls.Add(this.carte9Double);
            this.conteneurCarte.Controls.Add(this.carte9);
            this.conteneurCarte.Controls.Add(this.carte8double);
            this.conteneurCarte.Controls.Add(this.carte8);
            this.conteneurCarte.Controls.Add(this.carte7Double);
            this.conteneurCarte.Controls.Add(this.carte7);
            this.conteneurCarte.Controls.Add(this.carte6Double);
            this.conteneurCarte.Controls.Add(this.carte6);
            this.conteneurCarte.Controls.Add(this.carte5Double);
            this.conteneurCarte.Controls.Add(this.carte5);
            this.conteneurCarte.Controls.Add(this.carte4Double);
            this.conteneurCarte.Controls.Add(this.carte4);
            this.conteneurCarte.Controls.Add(this.carte3Double);
            this.conteneurCarte.Controls.Add(this.carte3);
            this.conteneurCarte.Controls.Add(this.carte2Double);
            this.conteneurCarte.Controls.Add(this.carte2);
            this.conteneurCarte.Controls.Add(this.carte1Double);
            this.conteneurCarte.Controls.Add(this.carte1);
            this.conteneurCarte.Location = new System.Drawing.Point(109, 30);
            this.conteneurCarte.Name = "conteneurCarte";
            this.conteneurCarte.Size = new System.Drawing.Size(817, 503);
            this.conteneurCarte.TabIndex = 3;
            // 
            // carte9Double
            // 
            this.carte9Double.Location = new System.Drawing.Point(683, 335);
            this.carte9Double.Name = "carte9Double";
            this.carte9Double.Size = new System.Drawing.Size(130, 160);
            this.carte9Double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte9Double.TabIndex = 17;
            this.carte9Double.TabStop = false;
            this.carte9Double.Tag = "9";
            this.carte9Double.Click += new System.EventHandler(this.jouer);
            // 
            // carte9
            // 
            this.carte9.Location = new System.Drawing.Point(547, 335);
            this.carte9.Name = "carte9";
            this.carte9.Size = new System.Drawing.Size(130, 160);
            this.carte9.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte9.TabIndex = 16;
            this.carte9.TabStop = false;
            this.carte9.Tag = "9";
            this.carte9.Click += new System.EventHandler(this.jouer);
            // 
            // carte8double
            // 
            this.carte8double.Location = new System.Drawing.Point(411, 335);
            this.carte8double.Name = "carte8double";
            this.carte8double.Size = new System.Drawing.Size(130, 160);
            this.carte8double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte8double.TabIndex = 15;
            this.carte8double.TabStop = false;
            this.carte8double.Tag = "8";
            this.carte8double.Click += new System.EventHandler(this.jouer);
            // 
            // carte8
            // 
            this.carte8.Location = new System.Drawing.Point(275, 335);
            this.carte8.Name = "carte8";
            this.carte8.Size = new System.Drawing.Size(130, 160);
            this.carte8.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte8.TabIndex = 14;
            this.carte8.TabStop = false;
            this.carte8.Tag = "8";
            this.carte8.Click += new System.EventHandler(this.jouer);
            // 
            // carte7Double
            // 
            this.carte7Double.Location = new System.Drawing.Point(139, 335);
            this.carte7Double.Name = "carte7Double";
            this.carte7Double.Size = new System.Drawing.Size(130, 160);
            this.carte7Double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte7Double.TabIndex = 13;
            this.carte7Double.TabStop = false;
            this.carte7Double.Tag = "7";
            this.carte7Double.Click += new System.EventHandler(this.jouer);
            // 
            // carte7
            // 
            this.carte7.Location = new System.Drawing.Point(3, 335);
            this.carte7.Name = "carte7";
            this.carte7.Size = new System.Drawing.Size(130, 160);
            this.carte7.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte7.TabIndex = 12;
            this.carte7.TabStop = false;
            this.carte7.Tag = "7";
            this.carte7.Click += new System.EventHandler(this.jouer);
            // 
            // carte6Double
            // 
            this.carte6Double.Location = new System.Drawing.Point(683, 169);
            this.carte6Double.Name = "carte6Double";
            this.carte6Double.Size = new System.Drawing.Size(130, 160);
            this.carte6Double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte6Double.TabIndex = 11;
            this.carte6Double.TabStop = false;
            this.carte6Double.Tag = "6";
            this.carte6Double.Click += new System.EventHandler(this.jouer);
            // 
            // carte6
            // 
            this.carte6.Location = new System.Drawing.Point(547, 169);
            this.carte6.Name = "carte6";
            this.carte6.Size = new System.Drawing.Size(130, 160);
            this.carte6.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte6.TabIndex = 10;
            this.carte6.TabStop = false;
            this.carte6.Tag = "6";
            this.carte6.Click += new System.EventHandler(this.jouer);
            // 
            // carte5Double
            // 
            this.carte5Double.Location = new System.Drawing.Point(411, 169);
            this.carte5Double.Name = "carte5Double";
            this.carte5Double.Size = new System.Drawing.Size(130, 160);
            this.carte5Double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte5Double.TabIndex = 9;
            this.carte5Double.TabStop = false;
            this.carte5Double.Tag = "5";
            this.carte5Double.Click += new System.EventHandler(this.jouer);
            // 
            // carte5
            // 
            this.carte5.Location = new System.Drawing.Point(275, 169);
            this.carte5.Name = "carte5";
            this.carte5.Size = new System.Drawing.Size(130, 160);
            this.carte5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte5.TabIndex = 8;
            this.carte5.TabStop = false;
            this.carte5.Tag = "5";
            this.carte5.Click += new System.EventHandler(this.jouer);
            // 
            // carte4Double
            // 
            this.carte4Double.Location = new System.Drawing.Point(139, 169);
            this.carte4Double.Name = "carte4Double";
            this.carte4Double.Size = new System.Drawing.Size(130, 160);
            this.carte4Double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte4Double.TabIndex = 7;
            this.carte4Double.TabStop = false;
            this.carte4Double.Tag = "4";
            this.carte4Double.Click += new System.EventHandler(this.jouer);
            // 
            // carte4
            // 
            this.carte4.Location = new System.Drawing.Point(3, 169);
            this.carte4.Name = "carte4";
            this.carte4.Size = new System.Drawing.Size(130, 160);
            this.carte4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte4.TabIndex = 6;
            this.carte4.TabStop = false;
            this.carte4.Tag = "4";
            this.carte4.Click += new System.EventHandler(this.jouer);
            // 
            // carte3Double
            // 
            this.carte3Double.Location = new System.Drawing.Point(683, 3);
            this.carte3Double.Name = "carte3Double";
            this.carte3Double.Size = new System.Drawing.Size(130, 160);
            this.carte3Double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte3Double.TabIndex = 5;
            this.carte3Double.TabStop = false;
            this.carte3Double.Tag = "3";
            this.carte3Double.Click += new System.EventHandler(this.jouer);
            // 
            // carte3
            // 
            this.carte3.Location = new System.Drawing.Point(547, 3);
            this.carte3.Name = "carte3";
            this.carte3.Size = new System.Drawing.Size(130, 160);
            this.carte3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte3.TabIndex = 4;
            this.carte3.TabStop = false;
            this.carte3.Tag = "3";
            this.carte3.Click += new System.EventHandler(this.jouer);
            // 
            // carte2Double
            // 
            this.carte2Double.Location = new System.Drawing.Point(411, 3);
            this.carte2Double.Name = "carte2Double";
            this.carte2Double.Size = new System.Drawing.Size(130, 160);
            this.carte2Double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte2Double.TabIndex = 3;
            this.carte2Double.TabStop = false;
            this.carte2Double.Tag = "2";
            this.carte2Double.Click += new System.EventHandler(this.jouer);
            // 
            // carte2
            // 
            this.carte2.Location = new System.Drawing.Point(275, 3);
            this.carte2.Name = "carte2";
            this.carte2.Size = new System.Drawing.Size(130, 160);
            this.carte2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte2.TabIndex = 2;
            this.carte2.TabStop = false;
            this.carte2.Tag = "2";
            this.carte2.Click += new System.EventHandler(this.jouer);
            // 
            // carte1Double
            // 
            this.carte1Double.Location = new System.Drawing.Point(139, 3);
            this.carte1Double.Name = "carte1Double";
            this.carte1Double.Size = new System.Drawing.Size(130, 160);
            this.carte1Double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte1Double.TabIndex = 1;
            this.carte1Double.TabStop = false;
            this.carte1Double.Tag = "1";
            this.carte1Double.Click += new System.EventHandler(this.jouer);
            // 
            // carte1
            // 
            this.carte1.Location = new System.Drawing.Point(3, 3);
            this.carte1.Name = "carte1";
            this.carte1.Size = new System.Drawing.Size(130, 160);
            this.carte1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte1.TabIndex = 0;
            this.carte1.TabStop = false;
            this.carte1.Tag = "1";
            this.carte1.Click += new System.EventHandler(this.jouer);
            // 
            // Memory16Panel
            // 
            this.ClientSize = new System.Drawing.Size(999, 528);
            this.Controls.Add(this.conteneurCarte);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Memory18";
            this.Text = "Memory18";
            this.conteneurCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carte9Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte8double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte7Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte6Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte5Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte4Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

