namespace La_petite_boite
{
    partial class tutoMemory
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
            this.conteneurCarte = new System.Windows.Forms.Panel();
            this.doubleCarte2 = new System.Windows.Forms.PictureBox();
            this.carte2 = new System.Windows.Forms.PictureBox();
            this.doubleCarte1 = new System.Windows.Forms.PictureBox();
            this.carte1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.conteneurCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleCarte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleCarte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneurCarte
            // 
            this.conteneurCarte.Controls.Add(this.doubleCarte2);
            this.conteneurCarte.Controls.Add(this.carte2);
            this.conteneurCarte.Controls.Add(this.doubleCarte1);
            this.conteneurCarte.Controls.Add(this.carte1);
            this.conteneurCarte.Location = new System.Drawing.Point(113, 60);
            this.conteneurCarte.Name = "conteneurCarte";
            this.conteneurCarte.Size = new System.Drawing.Size(314, 368);
            this.conteneurCarte.TabIndex = 0;
            // 
            // doubleCarte2
            // 
            this.doubleCarte2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doubleCarte2.Location = new System.Drawing.Point(167, 194);
            this.doubleCarte2.Name = "doubleCarte2";
            this.doubleCarte2.Size = new System.Drawing.Size(130, 160);
            this.doubleCarte2.TabIndex = 11;
            this.doubleCarte2.TabStop = false;
            this.doubleCarte2.Tag = "2";
            // 
            // carte2
            // 
            this.carte2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carte2.Location = new System.Drawing.Point(14, 194);
            this.carte2.Name = "carte2";
            this.carte2.Size = new System.Drawing.Size(130, 160);
            this.carte2.TabIndex = 10;
            this.carte2.TabStop = false;
            this.carte2.Tag = "2";
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
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trouve la paire !";
            // 
            // tutoMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.conteneurCarte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tutoMemory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tutoMemory";
            this.conteneurCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doubleCarte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleCarte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }

}


