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
            this.conteneurCarte.Location = new Point(0, 0);
            this.conteneurCarte.Name = "conteneurCarte";
            this.conteneurCarte.Size = new Size(610, 197);
            this.conteneurCarte.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new Point(463, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new Size(130, 160);
            this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "4";
            this.pictureBox4.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new Point(313, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(130, 160);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "3";
            this.pictureBox3.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new Point(163, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(130, 160);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "2";
            this.pictureBox2.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Point(16, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(130, 160);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            this.pictureBox1.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // Ecouter
            // 
            this.Ecouter.BackColor = SystemColors.HotTrack;
            this.Ecouter.FlatAppearance.BorderSize = 0;
            this.Ecouter.FlatStyle = FlatStyle.Flat;
            this.Ecouter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Ecouter.ForeColor = SystemColors.ControlLightLight;
            this.Ecouter.Location = new Point(200, 210);
            this.Ecouter.Name = "Ecouter";
            this.Ecouter.Size = new Size(198, 51);
            this.Ecouter.TabIndex = 1;
            this.Ecouter.Text = "Ecouter";
            this.Ecouter.UseVisualStyleBackColor = false;
            this.Ecouter.Click += new System.EventHandler(this.Ecouter_Click);
            // 
            // 
            // ChasseAuxMots
            // 
            this.ClientSize = new Size(700, 528);
            this.Location = new Point(340, 190);
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
            this.Ecouter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Ecouter.FlatAppearance.BorderSize = 0;
            this.Ecouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ecouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ecouter.Location = new System.Drawing.Point(220, 380);
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
            this.conteneurCarte.Location = new System.Drawing.Point(0, 0);
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
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Location = new System.Drawing.Point(340, 190);
            this.pictureBox1.Name = "pictureBox1";
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
            this.Ecouter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Ecouter.FlatAppearance.BorderSize = 0;
            this.Ecouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ecouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ecouter.Location = new System.Drawing.Point(0, 250);
            this.Ecouter.Name = "Ecouter";
            this.Ecouter.Size = new System.Drawing.Size(140, 51);
            this.Ecouter.TabIndex = 11;
            this.Ecouter.Text = "Ecouter";
            this.Ecouter.UseVisualStyleBackColor = false;
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
            this.conteneurCarte.Location = new System.Drawing.Point(0, 0);
            this.conteneurCarte.Name = "conteneurCarte";
            this.conteneurCarte.Size = new System.Drawing.Size(800, 550);
            this.conteneurCarte.TabIndex = 10;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(603, 372);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(130, 160);
            this.pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "12";
            this.pictureBox12.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(453, 372);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(130, 160);
            this.pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "11";
            this.pictureBox11.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(303, 372);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(130, 160);
            this.pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "10";
            this.pictureBox10.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(156, 372);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(130, 160);
            this.pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "9";
            this.pictureBox9.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(603, 195);
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
            this.pictureBox7.Location = new System.Drawing.Point(453, 195);
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
            this.pictureBox6.Location = new System.Drawing.Point(303, 195);
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
            this.pictureBox5.Location = new System.Drawing.Point(156, 195);
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
            this.pictureBox4.Location = new System.Drawing.Point(603, 17);
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
            this.pictureBox3.Location = new System.Drawing.Point(453, 17);
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
            this.pictureBox2.Location = new System.Drawing.Point(303, 17);
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
            this.pictureBox1.Location = new System.Drawing.Point(156, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 160);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            this.pictureBox1.Click += new System.EventHandler(this.CliquerReponse);
            // 
            // ChasseAuxMots12Panel
            // 
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Location = new System.Drawing.Point(250, 160);
            this.Controls.Add(this.Ecouter);
            this.Controls.Add(this.conteneurCarte);
            this.Name = "Form1";
            this.Text = "Form1";
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

