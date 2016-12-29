using Ressources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chasse_aux_mots
{
    public class chasseMots : Jeu.Jeu
    {
        public int score = 0;
        public int finalScore;
        public int index;
        public Panel conteneurCarte;
        public String carteACliquerTag;
        public String imageCliqueTag;
        public Random localisation = new Random();
        public List<Point> coordonneesCartes = new List<Point>(); //liste des localisations des PictureBox
        public List<Stream> sons = new List<Stream>();
        public Button Ecouter;
        public Boolean[] trouves;
        int indexCarte;

        public chasseMots ()
        {

        }

        public new void chargementPartie()
        {
            this.Enabled = true;
            this.Location = new Point(0, 0);
            this.Controls.Add(this.Ecouter);
            this.Controls.Add(this.conteneurCarte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BackgroundImage = items.fondBlanc;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            Ecouter.Enabled = true;
            Ecouter.BackColor = System.Drawing.SystemColors.HotTrack;
            Ecouter.FlatAppearance.BorderSize = 0;
            Ecouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Ecouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Ecouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            Ecouter.Name = "Ecouter";
            Ecouter.Size = new System.Drawing.Size(140, 51);
            Ecouter.Text = "Ecouter";
            Ecouter.UseVisualStyleBackColor = false;

            carteACliquerTag = "";
            imageCliqueTag = "";
            
            conteneurCarte.BackColor = Color.Transparent;
            conteneurCarte.Location = new System.Drawing.Point(15, 10);
            conteneurCarte.Name = "conteneurCarte";

            indexCarte = 0;
            //récupérer les localisations des cartes
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                if (conteneurCarte.Controls.Count == 4)
                {
                    image.Left = indexCarte * 145;
                    image.Top = 0;
                }
                else if (conteneurCarte.Controls.Count == 8)
                {
                    image.Left = indexCarte * 145;

                    if (indexCarte < 4)
                    {
                        image.Top = 0;
                    }
                    else
                    {
                        image.Left = (indexCarte-4) * 145;
                        image.Top = 183;
                    }
                }
                else
                {
                    
                    image.Left = indexCarte * 145;

                    if (indexCarte < 6)
                    {
                        image.Top = 0;
                    }
                    else
                    {
                        image.Left = (indexCarte - 6) * 145;
                        image.Top = 183;
                    }
                }
                
                image.Size = new Size(130, 160);
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.TabIndex = 3;
                image.TabStop = false;
                image.Enabled = true;
                image.Click += new System.EventHandler(this.CliquerReponse);
                coordonneesCartes.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
                indexCarte++;
            }

            //mélange des cartes
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                int next = localisation.Next(coordonneesCartes.Count);
                Point p = coordonneesCartes[next];
                image.Location = p;
                coordonneesCartes.Remove(p);

            }
        }

        public void AffichageDosCarte(PictureBox img, ref Boolean trouve)
        {
            img.Image = items.dosCarte;
            trouve = true;
        }

        public void JouerSon(Stream stream, int choix, ref String tag)
        {
            stream.Position = 0;
            SoundPlayer son = new SoundPlayer(stream);
            son.Play();
            tag = choix.ToString();
            son.Dispose();
        }

        public void reponse(int score, PictureBox img, ref Boolean trouve)
        {
            if (imageCliqueTag == carteACliquerTag)
            {
                JouerSon(items.applaudissement);
                AffichageDosCarte(img, ref trouve);
                img.Enabled = false;
                this.score++;

                if (this.score == finalScore)
                {
                    Ecouter.Enabled = false;
                    this.Enabled = false;
                    chargementPartie();
                }
            }
            else
            {
                JouerSon(items.pouet);
            }
        }

        public void CliquerReponse(object sender, EventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            imageCliqueTag = (String)image.Tag;

            reponse(finalScore, image, ref trouves[index]);
        }

    }
}
