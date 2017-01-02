using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ressources;
using System.Drawing.Text;

namespace Que_fait_le_Roi
{
    public class QueFaitLeRoiClass : Jeu.Jeu
    {
        public int finalScore;
        public int score;
        public int indexcarte;
        public Panel conteneurCarte;
        public Panel conteneurBouton;
        public Panel conteneurCarteAPlacer;
        public Random localisation = new Random();
        public List<Point> coordonneesCarte = new List<Point>();
        public List<Point> coordonneesBouton = new List<Point>();
        public List<Point> coordonneesCarteAPlacer = new List<Point>();
        public Image imageRecuperee;
        public String sonTag;
        public String carteTag;
        public String receveurTag;
        public Boolean sonBoutonEcoute;
        public List<Stream> sons = new List<Stream>();
        public Point mouseLocation;


        public QueFaitLeRoiClass ()
        {

        }

        public new void chargementPartie()
        {
            this.Enabled = true;
            carteTag = "";
            sonTag = "";
            receveurTag = "";
            sonBoutonEcoute = false;
            imageRecuperee = null;
            int indexEmplacement = 0;

            this.BackgroundImage = items.fondBlanc;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            conteneurBouton.BackColor = Color.Transparent;
            conteneurCarte.BackColor = Color.Transparent;
            conteneurCarteAPlacer.BackColor = Color.Transparent;

            //on prepare les boutons
            indexcarte = 0;
            foreach (Button bouton in conteneurBouton.Controls)
            {
                bouton.Enabled = true;
                bouton.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                bouton.Size = new Size(130, 37);
                bouton.UseVisualStyleBackColor = true;
                bouton.Top = 3;

                if (conteneurCarte.Controls.Count == 4)
                {
                    bouton.Left = indexcarte * 185;
                }
                else if (conteneurCarte.Controls.Count == 8)
                {
                    bouton.Left = indexcarte * 135;
                }
                else
                {
                    bouton.Left = indexcarte * 102;
                    bouton.Size = new Size(100, 37);
                }

                bouton.Tag = "";
                bouton.Click += new EventHandler(this.Ecouter);
                indexcarte++;
                coordonneesBouton.Add(bouton.Location);
            }

            //on prepare les emplacements 
            indexcarte = 0;
            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.BorderStyle = BorderStyle.FixedSingle;
                image.AllowDrop = false;
                image.Image = null;
                image.Size = new Size(130, 160);
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.BackColor = Color.Transparent;
                image.TabStop = false;
                image.Top = 5;

                if (conteneurCarte.Controls.Count == 4)
                {
                    image.Left = indexcarte * 185;
                }
                else if (conteneurCarte.Controls.Count == 8)
                {
                    image.Left = indexcarte * 135;
                }
                else
                {
                    image.Left = indexcarte * 102;
                    image.Size = new Size(100, 120);
                }

                image.DragDrop += new DragEventHandler(this.Image_DragDrop);
                image.DragEnter += new DragEventHandler(this.Image_DragEnter);
                coordonneesCarteAPlacer.Add(image.Location);
                indexcarte++;
            }

            //on melange les boutons et les emplacements
            foreach (Button bouton in conteneurBouton.Controls)
            {
                int next = localisation.Next(coordonneesBouton.Count);
                Point p = coordonneesBouton[next];
                Point pEmplacement = coordonneesCarteAPlacer[next];
                bouton.Location = p;
                conteneurCarteAPlacer.Controls[indexEmplacement].Location = pEmplacement;
                coordonneesBouton.Remove(p);
                coordonneesCarteAPlacer.Remove(pEmplacement);
                indexEmplacement++;
            }
            
            //on prepare les carte a placer
            indexcarte = 0;
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Visible = true;
                image.Enabled = true;
                image.BackColor = Color.White;
                //image.MouseMove += new MouseEventHandler(imageMouseMove);
                image.Cursor = Cursors.Hand;
                image.Size = new Size(130, 160);
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.TabStop = false;
                image.Top = 3;

                if (conteneurCarte.Controls.Count == 4)
                {
                    image.Left = indexcarte * 185;
                }
                else if (conteneurCarte.Controls.Count == 8) 
                {
                    image.Left = indexcarte * 135;
                }
                else
                {
                    image.Left = indexcarte * 102;
                    image.Size = new Size(100, 120);
                }
                
                image.MouseDown += new MouseEventHandler(this.receveurImage_MouseDown);
                image.MouseEnter += new EventHandler(imageMouseEnter);
                coordonneesCarte.Add(image.Location);
                indexcarte++;
            }

            //on melange les cartes
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                int next = localisation.Next(coordonneesCarte.Count);
                Point p = coordonneesCarte[next];
                image.Location = p;
                coordonneesCarte.Remove(p);
            }
            
            this.Controls.Add(this.conteneurBouton);
            this.Controls.Add(this.conteneurCarteAPlacer);
            this.Controls.Add(this.conteneurCarte);
        }
        
        public void Ecouter(object sender, EventArgs e)
        {
            int index;
            Button bouton = (Button)sender;
            sonTag = (String)bouton.Tag;
            sonBoutonEcoute = true;
            index = Int32.Parse((String)bouton.Tag) - 1;

            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.AllowDrop = true;
            }

            JouerSon(sons[index]);
        }

        public void Image_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        public void Image_DragDrop(object sender, DragEventArgs e)
        {
            int index = Int32.Parse(sonTag) - 1;
            PictureBox image = (PictureBox)sender;

            receveurTag = (String)image.Tag;

            if (carteTag == sonTag & receveurTag == sonTag)
            {
                image.Image = imageRecuperee;
                image.BackColor = Color.White;
                sonBoutonEcoute = false;
                JouerSon(items.applaudissement);
                conteneurCarte.Controls[index].Hide();
                image.Enabled = false;
                this.score++;
            }
            else
            {
                JouerSon(items.pouet);
                image.Image = null;
            }

            if (this.score == finalScore)
            {
                foreach (PictureBox imageCarte in conteneurCarte.Controls)
                {
                    imageCarte.Enabled = false;
                }

                foreach (Button bouton in conteneurBouton.Controls)
                {
                    bouton.Enabled = false;
                }

                this.Enabled = false;
                chargementPartie();
            }

        }

        private void imageMouseEnter(object sender, EventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            imageRecuperee = image.Image;
            carteTag = (String)image.Tag;
            int index = Int32.Parse(carteTag) + finalScore - 1;

            if (sonBoutonEcoute == true)
            {
                JouerSon(sons[index]);
            }
        }

        public void receveurImage_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            imageRecuperee = image.Image;
            carteTag = (String)image.Tag;
            int index = Int32.Parse(carteTag) + finalScore - 1;
            
            //on recupere la position de la souris
            if (e.Button == MouseButtons.Left)
            {
                Console.WriteLine(mouseLocation);
                mouseLocation = e.Location;
            }
            conteneurCarteAPlacer.DoDragDrop("x", DragDropEffects.All);
            
        }

        public void imageMouseMove(object sender, MouseEventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            Console.WriteLine(image.Name);
            Console.WriteLine(mouseLocation.X);
            image.Left = e.X;
            image.Top = e.Y;

            Refresh();
        }
    }

   
}
