using System.Drawing;
using System.Windows.Forms;

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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "8 cartes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 86);
            this.button2.TabIndex = 1;
            this.button2.Text = "12 cartes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(527, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 86);
            this.button3.TabIndex = 2;
            this.button3.Text = "16 cartes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Memory8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 700);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Memory8";
            this.Text = "Jeu Memory";
            this.ResumeLayout(false);

        }


        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
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
            this.conteneurCarte.Size = new System.Drawing.Size(628, 379);
            // 
            this.doubleCarte4.Tag = "4";
            this.carte4.Tag = "4";
            this.doubleCarte3.Tag = "3";
            this.carte3.Tag = "3";
            this.doubleCarte2.Tag = "2";
            this.carte2.Tag = "2";
            this.doubleCarte1.Tag = "1";
            this.carte1.Tag = "1";
            // 
            // MemoryPanel
            // 
            this.ClientSize = new System.Drawing.Size(820, 392);
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

    partial class Memory12Panel
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
            this.carte5 = new System.Windows.Forms.PictureBox();
            this.carte3 = new System.Windows.Forms.PictureBox();
            this.carte1 = new System.Windows.Forms.PictureBox();
            this.carte4Double = new System.Windows.Forms.PictureBox();
            this.carte4 = new System.Windows.Forms.PictureBox();
            this.carte3Double = new System.Windows.Forms.PictureBox();
            this.carte6 = new System.Windows.Forms.PictureBox();
            this.carte6Double = new System.Windows.Forms.PictureBox();
            this.carte2Double = new System.Windows.Forms.PictureBox();
            this.carte2 = new System.Windows.Forms.PictureBox();
            this.carte1Double = new System.Windows.Forms.PictureBox();
            this.carte5Double = new System.Windows.Forms.PictureBox();
            this.conteneurCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carte5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte4Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte6Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1Double)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte5Double)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneurCarte
            // 
            this.conteneurCarte.Controls.Add(this.carte5);
            this.conteneurCarte.Controls.Add(this.carte3);
            this.conteneurCarte.Controls.Add(this.carte1);
            this.conteneurCarte.Controls.Add(this.carte4Double);
            this.conteneurCarte.Controls.Add(this.carte4);
            this.conteneurCarte.Controls.Add(this.carte3Double);
            this.conteneurCarte.Controls.Add(this.carte6);
            this.conteneurCarte.Controls.Add(this.carte6Double);
            this.conteneurCarte.Controls.Add(this.carte2Double);
            this.conteneurCarte.Controls.Add(this.carte2);
            this.conteneurCarte.Controls.Add(this.carte1Double);
            this.conteneurCarte.Controls.Add(this.carte5Double);
            this.conteneurCarte.Size = new System.Drawing.Size(544, 650);
            // 
            this.carte5.Tag = "5";
            this.carte5Double.Tag = "5";
            this.carte3.Tag = "3";
            this.carte3Double.Tag = "3";
            this.carte1.Tag = "1";
            this.carte1Double.Tag = "1";
            this.carte4Double.Tag = "4";
            this.carte4.Tag = "4";
            this.carte6.Tag = "6";
            this.carte6Double.Tag = "6";
            this.carte2Double.Tag = "2";
            this.carte2.Tag = "2";
            // 
            // Memory12Panel
            // 
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.conteneurCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carte5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte4Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte6Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1Double)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte5Double)).EndInit();
        }
    }

    partial class Memory18Panel
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
            this.conteneurCarte.Size = new System.Drawing.Size(817, 503);
            // 
            // carte9Double
            // 
            this.carte9Double.Tag = "9";
            this.carte9.Tag = "9";
            this.carte8double.Tag = "8";
            this.carte8.Tag = "8";
            this.carte7Double.Tag = "7";
            this.carte7.Tag = "7";
            this.carte6Double.Tag = "6";
            this.carte6.Tag = "6";
            this.carte5Double.Tag = "5";
            this.carte5.Tag = "5";
            this.carte4Double.Tag = "4";
            this.carte4.Tag = "4";
            this.carte3Double.Tag = "3";
            this.carte3.Tag = "3";
            this.carte2Double.Tag = "2";
            this.carte2.Tag = "2";
            this.carte1Double.Tag = "1";
            this.carte1.Tag = "1";
            // 
            // Memory18Panel
            // 
            this.ClientSize = new System.Drawing.Size(1045, 540);
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

