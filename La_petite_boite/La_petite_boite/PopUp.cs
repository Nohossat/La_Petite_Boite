using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_petite_boite
{
    public partial class PopUp : Form
    {

        delegate void actionButton(object sender, EventArgs e);
        List<actionButton> tableauFonctions = new List<actionButton>();
        public Label message = new Label();
        public PictureBox animation = new PictureBox();

        public PopUp(Color fond, Bitmap animation, int nbrBoutons, String message, List<String> texteBoutons, List<int> referenceMethods)
        {
            InitializeComponent();

            this.Controls.Add(this.message);
            this.Controls.Add(this.animation);
            // 
            //message
            this.message.AutoSize = true;
            this.message.Font = new Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = Color.White;
            this.message.Location = new Point(252, 167);
            this.message.Name = "message";
            this.message.Size = new Size(400, 75);
            this.message.TabIndex = 3;
            this.message.TextAlign = ContentAlignment.MiddleCenter;
            this.message.Text = message;
            // 
            // animation
            // 
            this.animation.Location = new Point(191, 25);
            this.animation.Name = "animation";
            this.animation.Size = new Size(234, 200);
            this.animation.TabIndex = 4;
            this.animation.TabStop = false;
            this.animation.Image = animation;
            this.animation.SizeMode = PictureBoxSizeMode.StretchImage;


            tableauFonctions.Add(Retour);
            tableauFonctions.Add(Carte);
            tableauFonctions.Add(Niveau1);
            tableauFonctions.Add(Niveau2);
            tableauFonctions.Add(SauvegardeQuitter);
            tableauFonctions.Add(Quitter);
            BackColor = fond;


            if (nbrBoutons == 1)
            {
                Button bouton1 = new Button();
                this.Controls.Add(bouton1);
                bouton1.Width = 195;
                bouton1.Height = 55;
                bouton1.Top = 223;
                bouton1.Left = 213;
                bouton1.Text = texteBoutons.ElementAt(0);
                bouton1.Click += new EventHandler(tableauFonctions.ElementAt(referenceMethods.ElementAt(0)));
            }
            else if (nbrBoutons == 2)
            {
                Button bouton1 = new Button();
                Button bouton2 = new Button();
                this.Controls.Add(bouton1);
                this.Controls.Add(bouton2);

                for (int i = 0; i < 2; i++)
                {
                    this.Controls[i].Width = 195;
                    this.Controls[i].Height = 55;
                    this.Controls[i].Top = 223;
                    this.Controls[i].Left = i * 230 + 30;
                    this.Controls[i].Text = texteBoutons.ElementAt(i);
                    this.Controls[i].Click += new EventHandler(tableauFonctions.ElementAt(referenceMethods.ElementAt(i)));
                }
            }
            else
            {
                //nbrBoutons == 3
                Button bouton1 = new Button();
                Button bouton2 = new Button();
                Button bouton3 = new Button();
                this.Controls.Add(bouton1);
                this.Controls.Add(bouton2);
                this.Controls.Add(bouton3);

                for (int i = 0; i < 3; i++)
                {
                    this.Controls[i].Width = 156;
                    this.Controls[i].Height = 55;
                    this.Controls[i].Top = 223;
                    this.Controls[i].Left = i * 206 + 26;
                    this.Controls[i].Text = texteBoutons.ElementAt(i);
                    this.Controls[i].Click += new EventHandler(tableauFonctions.ElementAt(referenceMethods.ElementAt(i)));
                }
            }
        }

        void Retour(object sender, EventArgs e)
        {
            //on referme la form
            this.Close();
            this.Dispose();
        }

        void Carte(object sender, EventArgs e)
        {
            Program.petiteBoite.choixFinMiniJeu = 0;
            //on referme la form
            this.Close();
            this.Dispose();
        }

        void Niveau1(object sender, EventArgs e)
        {
            Program.petiteBoite.choixFinMiniJeu = 1;
            //on referme la form
            this.Close();
            this.Dispose();
        }

        void Niveau2(object sender, EventArgs e)
        {
            Program.petiteBoite.choixFinMiniJeu = 2;

            //on referme la form
            this.Close();
            this.Dispose();
        }

        void SauvegardeQuitter(object sender, EventArgs e)
        {
            Program.petiteBoite.choixFinMiniJeu = 3;
            //on referme la form
            this.Close();
            this.Dispose();
        }

        void Quitter(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
