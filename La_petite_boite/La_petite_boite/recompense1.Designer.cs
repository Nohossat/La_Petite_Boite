namespace La_petite_boite
{
    partial class recompense1
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "recompense1";
        }

        #endregion
    }

    partial class recompense
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

        private void initialize()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chanson";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.chanson);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Coloriages";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.coloriage);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(777, 463);
            this.Location = new System.Drawing.Point(130, 80);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}