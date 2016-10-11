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
            this.SuspendLayout();
            // 
            // QueFaitLeRoi
            // 
            this.ClientSize = new System.Drawing.Size(896, 532);
            this.Name = "QueFaitLeRoi";
            this.Text = "QueFaitLeRoi4";
            this.ResumeLayout(false);

        }
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.conteneurCarte = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.conteneurBouton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
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
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 37);
            this.button1.TabIndex = 1;
            this.button1.Tag = "";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Ecouter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(188, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 37);
            this.button2.TabIndex = 4;
            this.button2.Tag = "";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Ecouter);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(367, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 37);
            this.button3.TabIndex = 3;
            this.button3.Tag = "";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Ecouter);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(546, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 37);
            this.button4.TabIndex = 2;
            this.button4.Tag = "";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Ecouter);
            // 
            // conteneurCarte
            // 
            this.conteneurCarte.Controls.Add(this.pictureBox4);
            this.conteneurCarte.Controls.Add(this.pictureBox1);
            this.conteneurCarte.Controls.Add(this.pictureBox2);
            this.conteneurCarte.Controls.Add(this.pictureBox3);
            this.conteneurCarte.Location = new System.Drawing.Point(90, 275);
            this.conteneurCarte.Name = "conteneurCarte";
            this.conteneurCarte.Size = new System.Drawing.Size(700, 167);
            this.conteneurCarte.TabIndex = 8;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Image = global::Que_fait_le_Roi.Properties.Resources.jardin;
            this.pictureBox4.Location = new System.Drawing.Point(543, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 160);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "4";
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.receveurImage_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Que_fait_le_Roi.Properties.Resources.chateau;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.receveurImage_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Que_fait_le_Roi.Properties.Resources.ecole;
            this.pictureBox2.Location = new System.Drawing.Point(188, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 160);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "2";
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.receveurImage_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Que_fait_le_Roi.Properties.Resources.foret;
            this.pictureBox3.Location = new System.Drawing.Point(367, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 160);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "3";
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.receveurImage_MouseDown);
            // 
            // conteneurBouton
            // 
            this.conteneurBouton.Controls.Add(this.button1);
            this.conteneurBouton.Controls.Add(this.button2);
            this.conteneurBouton.Controls.Add(this.button3);
            this.conteneurBouton.Controls.Add(this.button4);
            this.conteneurBouton.Location = new System.Drawing.Point(90, 5);
            this.conteneurBouton.Name = "conteneurBouton";
            this.conteneurBouton.Size = new System.Drawing.Size(676, 44);
            this.conteneurBouton.TabIndex = 10;
            // 
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Score";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(17, 113);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(0, 20);
            this.Score.TabIndex = 13;
            // 
            // conteneurCarteAPlacer
            // 
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox5);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox6);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox7);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox8);
            this.conteneurCarteAPlacer.Location = new System.Drawing.Point(90, 55);
            this.conteneurCarteAPlacer.Name = "conteneurCarteAPlacer";
            this.conteneurCarteAPlacer.Size = new System.Drawing.Size(700, 168);
            this.conteneurCarteAPlacer.TabIndex = 9;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(3, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 160);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "1";
            this.pictureBox5.DragDrop += new System.Windows.Forms.DragEventHandler(this.Image_DragDrop);
            this.pictureBox5.DragEnter += new System.Windows.Forms.DragEventHandler(this.Image_DragEnter);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(188, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(130, 160);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "2";
            this.pictureBox6.DragDrop += new System.Windows.Forms.DragEventHandler(this.Image_DragDrop);
            this.pictureBox6.DragEnter += new System.Windows.Forms.DragEventHandler(this.Image_DragEnter);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(367, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(130, 160);
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "3";
            this.pictureBox7.DragDrop += new System.Windows.Forms.DragEventHandler(this.Image_DragDrop);
            this.pictureBox7.DragEnter += new System.Windows.Forms.DragEventHandler(this.Image_DragEnter);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(543, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(130, 160);
            this.pictureBox8.TabIndex = 3;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "4";
            this.pictureBox8.DragDrop += new System.Windows.Forms.DragEventHandler(this.Image_DragDrop);
            this.pictureBox8.DragEnter += new System.Windows.Forms.DragEventHandler(this.Image_DragEnter);
            // 
            // QueFaitLeRoiPanel
            this.ClientSize = new System.Drawing.Size(999, 600);
            this.Location = new System.Drawing.Point(120, 100);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conteneurBouton);
            this.Controls.Add(this.conteneurCarteAPlacer);
            this.Controls.Add(this.conteneurCarte);
            this.Name = "QueFaitLeRoi";
            this.Text = "QueFaitLeRoi4";
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
}

