using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ressources;

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
            
            // 
            //message
            this.message.Font = new Font(Form1.privateFontCollection.Families[0], 15);
            this.message.ForeColor = Color.White;
            this.message.BackColor = Color.Transparent;
            this.message.Location = new Point(96, 140);
            this.message.Size = new Size(440, 75);
            this.message.TabIndex = 3;
            this.message.TextAlign = ContentAlignment.MiddleCenter;
            this.message.Text = message;
            // 
            // animation
            // 
            this.animation.Location = new Point(210, 20);
            this.animation.Size = new Size(190, 120);
            this.animation.TabIndex = 4;
            this.animation.TabStop = false;
            this.animation.Image = animation;
            this.animation.BackColor = Color.Transparent;
            this.animation.SizeMode = PictureBoxSizeMode.StretchImage;

            //on stocke les fonctions dans un tableau pour pouvoir les appeler plus facilement
            tableauFonctions.Add(Retour);
            tableauFonctions.Add(Carte);
            tableauFonctions.Add(Niveau1);
            tableauFonctions.Add(Niveau2);
            tableauFonctions.Add(SauvegardeRetourAccueil);
            tableauFonctions.Add(RetourAccueil);
            tableauFonctions.Add(Quitter);
            BackColor = fond;
            
            if (nbrBoutons == 1)
            {
                popUpButton bouton1 = new popUpButton();
                this.Controls.Add(bouton1);
                bouton1.Width = 195;
                bouton1.Height = 55;
                bouton1.Left = 213;
                bouton1.Text = texteBoutons.ElementAt(0);
                bouton1.Font = new Font(Form1.privateFontCollection.Families[0], 14);
                bouton1.Click += new EventHandler(tableauFonctions.ElementAt(referenceMethods.ElementAt(0)));
            }
            else if (nbrBoutons == 2)
            {
                popUpButton bouton1 = new popUpButton();
                popUpButton bouton2 = new popUpButton();
                this.Controls.Add(bouton1);
                this.Controls.Add(bouton2);

                //sur la form pour l'instant il n'y a que des boutons
                for (int i = 0; i < 2; i++)
                {
                    this.Controls[i].Width = 195;
                    this.Controls[i].Height = 55;
                    this.Controls[i].Left = i * 230 + 100;
                    this.Controls[i].Font = new Font(Form1.privateFontCollection.Families[0], 14);
                    this.Controls[i].Text = texteBoutons.ElementAt(i);
                    this.Controls[i].Click += new EventHandler(tableauFonctions.ElementAt(referenceMethods.ElementAt(i)));
                }
            }
            else if (nbrBoutons == 3)
            {
                //nbrBoutons == 3
                popUpButton bouton1 = new popUpButton();
                popUpButton bouton2 = new popUpButton();
                popUpButton bouton3 = new popUpButton();
                this.Controls.Add(bouton1);
                this.Controls.Add(bouton2);
                this.Controls.Add(bouton3);

                //sur la form pour l'instant il n'y a que des boutons
                for (int i = 0; i < 3; i++)
                {
                    this.Controls[i].Width = 156;
                    this.Controls[i].Height = 55;
                    this.Controls[i].Left = i * 206 + 26;
                    this.Controls[i].Font = new Font(Form1.privateFontCollection.Families[0], 14);
                    this.Controls[i].Text = texteBoutons.ElementAt(i);
                    this.Controls[i].Click += new EventHandler(tableauFonctions.ElementAt(referenceMethods.ElementAt(i)));
                }
            }
            this.Controls.Add(this.message);
            this.Controls.Add(this.animation);
        }
        
        void Retour(object sender, EventArgs e)
        {
            Program.petiteBoite.choixFinMiniJeu = -1;
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

        void SauvegardeRetourAccueil(object sender, EventArgs e)
        {
            Program.petiteBoite.choixFinMiniJeu = 3;
            //on referme la form
            this.Close();
            this.Dispose();
        }

        void RetourAccueil(object sender, EventArgs e)
        {
            Program.petiteBoite.choixFinMiniJeu = 4;
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
