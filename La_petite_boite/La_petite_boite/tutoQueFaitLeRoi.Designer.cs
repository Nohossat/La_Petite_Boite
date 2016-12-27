namespace La_petite_boite
{
    partial class tutoQueFaitLeRoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.conteneurCarte = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.conteneurBouton = new System.Windows.Forms.Panel();
            this.conteneurCarteAPlacer = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.conteneurCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.conteneurBouton.SuspendLayout();
            this.conteneurCarteAPlacer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();

            // conteneurBouton
            // 
            this.conteneurBouton.Controls.Add(this.button1);
            this.conteneurBouton.Controls.Add(this.button2);
            this.conteneurBouton.Location = new System.Drawing.Point(160, 100);
            this.conteneurBouton.Name = "conteneurBouton";
            this.conteneurBouton.Size = new System.Drawing.Size(334, 42);
            this.conteneurBouton.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 1;
            this.button1.Tag = "";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(130, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 4;
            this.button2.Tag = "";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // conteneurCarte
            // 
            this.conteneurCarte.Controls.Add(this.pictureBox1);
            this.conteneurCarte.Controls.Add(this.pictureBox2);
            this.conteneurCarte.Location = new System.Drawing.Point(160, 300);
            this.conteneurCarte.Name = "conteneurCarte";
            this.conteneurCarte.Size = new System.Drawing.Size(334, 140);
            this.conteneurCarte.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(130, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 130);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "2";
            // 
            // 
            // conteneurCarteAPlacer
            // 
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox5);
            this.conteneurCarteAPlacer.Controls.Add(this.pictureBox6);
            this.conteneurCarteAPlacer.Location = new System.Drawing.Point(160, 150);
            this.conteneurCarteAPlacer.Name = "conteneurCarteAPlacer";
            this.conteneurCarteAPlacer.Size = new System.Drawing.Size(334, 140);
            this.conteneurCarteAPlacer.TabIndex = 9;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 130);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "1";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(130, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 130);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(443, 52);
            this.button3.TabIndex = 11;
            this.button3.Text = "GO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tutoQueFaitLeRoi
            // 
            
            this.Controls.Add(this.button3);
            this.Controls.Add(this.conteneurBouton);
            this.Controls.Add(this.conteneurCarteAPlacer);
            this.Controls.Add(this.conteneurCarte);
            this.Name = "tutoQueFaitLeRoi";
            this.Text = "QueFaitLeRoi4";
            this.conteneurCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.conteneurBouton.ResumeLayout(false);
            this.conteneurCarteAPlacer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}