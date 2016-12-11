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
            this.ClientSize = new System.Drawing.Size(978, 575);
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
            this.conteneurCarte.Location = new System.Drawing.Point(0, 0);
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
            this.doubleCarte4.SizeMode = PictureBoxSizeMode.StretchImage;
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
            this.carte4.SizeMode = PictureBoxSizeMode.StretchImage;
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
            this.doubleCarte3.SizeMode = PictureBoxSizeMode.StretchImage;
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
            this.carte3.SizeMode = PictureBoxSizeMode.StretchImage;
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
            this.doubleCarte2.SizeMode = PictureBoxSizeMode.StretchImage;
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
            this.carte2.SizeMode = PictureBoxSizeMode.StretchImage;
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
            this.doubleCarte1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            this.carte1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte1.TabIndex = 8;
            this.carte1.TabStop = false;
            this.carte1.Tag = "1";
            this.carte1.Click += new System.EventHandler(this.jouer);
            // 
            // 
            // MemoryPanel
            // 
            this.ClientSize = new System.Drawing.Size(999, 528);
            this.Location = new System.Drawing.Point(0, 0);
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
            this.conteneurCarte.Location = new System.Drawing.Point(0, 0);
            this.conteneurCarte.Name = "conteneurCarte";
            this.conteneurCarte.Size = new System.Drawing.Size(544, 650);
            this.conteneurCarte.TabIndex = 0;
            // 
            // carte5
            // 
            this.carte5.Location = new System.Drawing.Point(3, 335);
            this.carte5.Name = "carte5";
            this.carte5.Size = new System.Drawing.Size(130, 160);
            this.carte5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte5.TabIndex = 14;
            this.carte5.TabStop = false;
            this.carte5.Tag = "5";
            this.carte5.Click += new System.EventHandler(this.jouer);
            // 
            // carte3
            // 
            this.carte3.Location = new System.Drawing.Point(3, 169);
            this.carte3.Name = "carte3";
            this.carte3.Size = new System.Drawing.Size(130, 160);
            this.carte3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte3.TabIndex = 13;
            this.carte3.TabStop = false;
            this.carte3.Tag = "3";
            this.carte3.Click += new System.EventHandler(this.jouer);
            // 
            // carte1
            // 
            this.carte1.Location = new System.Drawing.Point(3, 3);
            this.carte1.Name = "carte1";
            this.carte1.Size = new System.Drawing.Size(130, 160);
            this.carte1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte1.TabIndex = 12;
            this.carte1.TabStop = false;
            this.carte1.Tag = "1";
            this.carte1.Click += new System.EventHandler(this.jouer);
            // 
            // carte4Double
            // 
            this.carte4Double.Location = new System.Drawing.Point(411, 169);
            this.carte4Double.Name = "carte4Double";
            this.carte4Double.Size = new System.Drawing.Size(130, 160);
            this.carte4Double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte4Double.TabIndex = 10;
            this.carte4Double.TabStop = false;
            this.carte4Double.Tag = "4";
            this.carte4Double.Click += new System.EventHandler(this.jouer);
            // 
            // carte4
            // 
            this.carte4.Location = new System.Drawing.Point(275, 169);
            this.carte4.Name = "carte4";
            this.carte4.Size = new System.Drawing.Size(130, 160);
            this.carte4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte4.TabIndex = 9;
            this.carte4.TabStop = false;
            this.carte4.Tag = "4";
            this.carte4.Click += new System.EventHandler(this.jouer);
            // 
            // carte3Double
            // 
            this.carte3Double.Location = new System.Drawing.Point(139, 169);
            this.carte3Double.Name = "carte3Double";
            this.carte3Double.Size = new System.Drawing.Size(130, 160);
            this.carte3Double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte3Double.TabIndex = 8;
            this.carte3Double.TabStop = false;
            this.carte3Double.Tag = "3";
            this.carte3Double.Click += new System.EventHandler(this.jouer);
            // 
            // carte6
            // 
            this.carte6.Location = new System.Drawing.Point(275, 335);
            this.carte6.Name = "carte6";
            this.carte6.Size = new System.Drawing.Size(130, 160);
            this.carte6.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte6.TabIndex = 7;
            this.carte6.TabStop = false;
            this.carte6.Tag = "6";
            this.carte6.Click += new System.EventHandler(this.jouer);
            // 
            // carte6Double
            // 
            this.carte6Double.Location = new System.Drawing.Point(411, 335);
            this.carte6Double.Name = "carte6Double";
            this.carte6Double.Size = new System.Drawing.Size(130, 160);
            this.carte6Double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte6Double.TabIndex = 6;
            this.carte6Double.TabStop = false;
            this.carte6Double.Tag = "6";
            this.carte6Double.Click += new System.EventHandler(this.jouer);
            // 
            // carte2Double
            // 
            this.carte2Double.Location = new System.Drawing.Point(411, 3);
            this.carte2Double.Name = "carte2Double";
            this.carte2Double.Size = new System.Drawing.Size(130, 160);
            this.carte2Double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte2Double.TabIndex = 4;
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
            this.carte2.TabIndex = 3;
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
            this.carte1Double.TabIndex = 2;
            this.carte1Double.TabStop = false;
            this.carte1Double.Tag = "1";
            this.carte1Double.Click += new System.EventHandler(this.jouer);
            // 
            // carte5Double
            // 
            this.carte5Double.Location = new System.Drawing.Point(139, 335);
            this.carte5Double.Name = "carte5Double";
            this.carte5Double.Size = new System.Drawing.Size(130, 160);
            this.carte5Double.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carte5Double.TabIndex = 1;
            this.carte5Double.TabStop = false;
            this.carte5Double.Tag = "5";
            this.carte5Double.Click += new System.EventHandler(this.jouer);
            // 
            // Memory12Panel
            // 
            this.ClientSize = new System.Drawing.Size(999, 700);
            this.Controls.Add(this.conteneurCarte);
            this.Name = "Memory12";
            this.Text = "Form1";
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
            this.conteneurCarte.Location = new System.Drawing.Point(0, 0);
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
            this.Location = new System.Drawing.Point(0, 0);
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

