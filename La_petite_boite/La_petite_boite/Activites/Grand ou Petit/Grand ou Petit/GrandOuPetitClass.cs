using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ressources;
using System.IO;
using System.Runtime.InteropServices;

namespace Grand_ou_Petit
{
    public class GrandOuPetitClass : Jeu.Jeu
    {
        public int score = 0;
        public int finalScore;
        public Random localisation = new Random();
        public List<Point> coordonneesGrandeCarte = new List<Point>(); //liste des localisations des PictureBox
        public List<Point> coordonneesCarteAPlacer = new List<Point>(); //liste des localisations des PictureBox
        public List<Point> coordonneesPetiteCarte = new List<Point>(); //liste des localisations des PictureBox
        public Image petiteImageRecup;
        public Boolean carteRetournee;
        public Boolean cartePetiteDejaSelectionnee;
        public String premiereCarteSelectionnee;
        public String deuxiemeCarteSelectionnee;
        public String destinationCarte;
        public Panel conteneurGrandeCarte;
        public Panel conteneurCarteAPlacer;
        public Panel conteneurPetiteCarte;
        public List<Bitmap> img = new List<Bitmap>();
        public List<Stream> sons = new List<Stream>();
        int index;
        int indexEmplacement;
        int indexCarte;

        public GrandOuPetitClass()
        {

        }

        public new void chargementPartie()
        {
            this.Enabled = true;
            this.BackgroundImage = items.fondBlanc;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Location = new Point(0, 0);
            this.Controls.Add(this.conteneurPetiteCarte);
            this.Controls.Add(this.conteneurCarteAPlacer);
            this.Controls.Add(this.conteneurGrandeCarte);
            this.Name = "GrandOuPetit";

            conteneurGrandeCarte.BackColor = Color.Transparent;
            conteneurPetiteCarte.BackColor = Color.Transparent;
            conteneurCarteAPlacer.BackColor = Color.Transparent;

            carteRetournee = false;
            cartePetiteDejaSelectionnee = false;
            premiereCarteSelectionnee = "";
            deuxiemeCarteSelectionnee = "";
            destinationCarte = "";
            petiteImageRecup = null;
            indexEmplacement = 0;
            indexCarte = 0;

            //récupérer les localisations des grandes cartes
            foreach (PictureBox image in conteneurGrandeCarte.Controls)
            {
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.BackColor = Color.Transparent;
                image.TabStop = false;
                image.Image = items.dosCarte;
                image.Enabled = true;
                image.Cursor = Cursors.Hand;
                image.Click += new EventHandler(this.cliquerPremiereLigne);
                image.Top = 0;

                if (conteneurGrandeCarte.Controls.Count == 10)
                {
                    //Grand Ou Petit 10
                    image.Size = new Size(100, 130);
                    image.Left = indexCarte * 105;
                }
                else if (conteneurGrandeCarte.Controls.Count == 8)
                {
                    //Grand Ou Petit 8
                    image.Size = new Size(120, 150);
                    image.Left = indexCarte * 135;
                }
                else
                {
                    //Grand Ou Petit
                    image.Size = new Size(130, 160);
                    image.Left = indexCarte * 145;
                }
                indexCarte++;
                coordonneesGrandeCarte.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
            }

            //initialisation de l'index pour la prochaine boucle
            indexCarte = 0;

            //récupérer les localisations des emplacements
            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.TabStop = false;
                image.BackColor = Color.Transparent;
                image.Enabled = true;
                image.AllowDrop = false;
                image.Image = null;
                image.BorderStyle = BorderStyle.FixedSingle;
                image.DragDrop += new DragEventHandler(this.petiteImage_DragDrop);
                image.DragEnter += new DragEventHandler(this.petiteImage_DragEnter);
                image.DragOver += new DragEventHandler(this.petiteImageDragOver);
                image.Top = 0;

                if (conteneurCarteAPlacer.Controls.Count == 10)
                {
                    //Grand Ou Petit 10
                    image.Size = new Size(100, 130);
                    image.Left = indexCarte * 105;
                }
                else if (conteneurCarteAPlacer.Controls.Count == 8)
                {
                    //Grand Ou Petit 8
                    image.Size = new Size(120, 150);
                    image.Left = indexCarte * 135;
                }
                else
                {
                    //Grand Ou Petit
                    image.Size = new Size(130, 160);
                    image.Left = indexCarte * 145;
                }

                coordonneesCarteAPlacer.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
                indexCarte++;
            }

            indexCarte = 0;
            //mélange des grandes cartes et des emplacements respectifs
            foreach (PictureBox image in conteneurGrandeCarte.Controls)
            {
                int next = localisation.Next(coordonneesGrandeCarte.Count);
                Point p = coordonneesGrandeCarte[next];
                Point pEmplacement = coordonneesCarteAPlacer[next];
                image.Location = p;
                conteneurCarteAPlacer.Controls[indexEmplacement].Location = pEmplacement;
                coordonneesGrandeCarte.Remove(p);
                coordonneesCarteAPlacer.Remove(conteneurCarteAPlacer.Controls[indexEmplacement].Location);
                indexEmplacement++;
            }


            //récupérer les localisations des petites cartes
            foreach (PictureBox image in conteneurPetiteCarte.Controls)
            {
                image.Enabled = true;
                image.Visible = true;
                image.BackColor = Color.Transparent;
                image.Cursor = Cursors.Hand;
                image.Image = items.dosCarte;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.TabStop = false;
                image.Top = 0;

                if (conteneurPetiteCarte.Controls.Count == 10)
                {
                    //Grand Ou Petit 10
                    image.Size = new Size(100, 130);
                    image.Left = indexCarte * 105;
                }
                else if (conteneurPetiteCarte.Controls.Count == 8)
                {
                    //Grand Ou Petit 8
                    image.Size = new Size(120, 150);
                    image.Left = indexCarte * 135;
                }
                else
                {
                    //Grand Ou Petit
                    image.Size = new Size(130, 160);
                    image.Left = indexCarte * 145;
                }

                coordonneesPetiteCarte.Add(image.Location); //on ajoute à la liste points la localisation des PictureBox
                image.MouseDown += new MouseEventHandler(this.receveurImage_MouseDown);
                image.MouseEnter += new EventHandler(this.receveurImage_MouseEnter);
                image.GiveFeedback += new GiveFeedbackEventHandler(this.DragSource_GiveFeedback);
                indexCarte++;
            }

            //mélange des cartes
            foreach (PictureBox image in conteneurPetiteCarte.Controls)
            {
                int next = localisation.Next(coordonneesPetiteCarte.Count);
                Point p = coordonneesPetiteCarte[next];
                image.Location = p;
                coordonneesPetiteCarte.Remove(p);
            }

            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(this.petiteImage_DragEnter);
            this.DragOver += new DragEventHandler(this.petiteImageDragOver);
        }

        private void cliquerPremiereLigne(object sender, EventArgs e)
        {
            if (cartePetiteDejaSelectionnee == false)
            {
                //on retient la carte cliquee dans la premiere rangee
                PictureBox carteCourante = (PictureBox)sender;
                premiereCarteSelectionnee = (String)carteCourante.Tag;
                carteRetournee = true;
                index = Int32.Parse(premiereCarteSelectionnee) - 1;

                //on devoile la carte
                carteCourante.BackColor = Color.White;
                carteCourante.Image = img[index];
                Refresh();


                //on ecoute le son associe a la carte
                JouerSon(sons[index]);

                //les autres cartes doivent etre retournees
                foreach (PictureBox image in conteneurGrandeCarte.Controls)
                {
                    if (image.Tag != carteCourante.Tag & image.Enabled != false)
                    {
                        image.Image = items.dosCarte;
                    }
                }
            }
        }

        private void petiteImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            Cursor.Current = CursorUtil.CreateCursor((Bitmap)petiteImageRecup, 0, 0);
        }

        private void petiteImage_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            image.Image = new Bitmap(petiteImageRecup, new Size(80, 104));
            image.BackColor = Color.White;
            image.SizeMode = PictureBoxSizeMode.CenterImage;
            Refresh();
            destinationCarte = (String)image.Tag;

            if (premiereCarteSelectionnee.Equals(deuxiemeCarteSelectionnee) & premiereCarteSelectionnee.Equals(destinationCarte))
            {
                this.score++;
                cartePetiteDejaSelectionnee = false;
                carteRetournee = false;
                conteneurPetiteCarte.Controls[index].Hide();
                conteneurPetiteCarte.Controls[index].Cursor = Cursors.Default;
                conteneurGrandeCarte.Controls[index].Enabled = false;
                JouerSon(items.applaudissement);
                image.Enabled = false;
            }
            else
            {
                JouerSon(items.pouet);
                image.Image = null;
            }

            if (this.score == finalScore)
            {
                foreach (PictureBox imageGrande in conteneurGrandeCarte.Controls)
                {
                    imageGrande.Enabled = false;
                }

                this.Enabled = false;
                chargementPartie();
            }
        }

        private void receveurImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (carteRetournee == true)
            {
                //on recupere les donnees de la petite carte
                PictureBox image = (PictureBox)sender;
                deuxiemeCarteSelectionnee = (String)image.Tag;
                cartePetiteDejaSelectionnee = true;
                int index = Int32.Parse(deuxiemeCarteSelectionnee) - 1;

                //on retourne toutes les cartes
                foreach (PictureBox petiteImage in conteneurPetiteCarte.Controls)
                {
                    if (petiteImage.Tag != image.Tag)
                    {
                        petiteImage.Image = items.dosCarte;
                        petiteImage.BackColor = Color.Transparent;
                        petiteImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        petiteImage.Refresh();
                    }
                }

                image.Image = new Bitmap(img[index], new Size(80, 104));
                image.SizeMode = PictureBoxSizeMode.CenterImage;
                image.BackColor = Color.White;
                image.Refresh();


                foreach (PictureBox petiteImage in conteneurCarteAPlacer.Controls)
                {
                    petiteImage.AllowDrop = true;
                }
                this.AllowDrop = true;
                //lecture du son lié à la petite carte
                petiteImageRecup = image.Image;
                conteneurCarteAPlacer.DoDragDrop("x", DragDropEffects.Move);
            }
        }

        private void receveurImage_MouseEnter(object sender, EventArgs e)
        {
            PictureBox image = (PictureBox)sender;

            if (image.SizeMode == PictureBoxSizeMode.CenterImage)
            {
                deuxiemeCarteSelectionnee = (String)image.Tag;
                int index = Int32.Parse(deuxiemeCarteSelectionnee) - 1;
                JouerSon(sons[index + finalScore]);
            }
        }

        private void petiteImageDragOver(object sender, DragEventArgs e)
        {
            Cursor.Current = CursorUtil.CreateCursor((Bitmap)petiteImageRecup, 0, 0);
            Refresh();
        }

        private void DragSource_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            //customize the drag cursor for the given DragDropEffect for this control
            Cursor.Current = CursorUtil.CreateCursor((Bitmap)petiteImageRecup, 0, 0);
        }

    }

    public class CursorUtil
    {
        public struct IconInfo
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

        [DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr handle);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        // Based on the article and comments here:
        // http://www.switchonthecode.com/tutorials/csharp-tutorial-how-to-use-custom-cursors
        // Note that the returned Cursor must be disposed of after use, or you'll leak memory!

        public static Cursor CreateCursor(Bitmap bm, int xHotspot, int yHotspot)
        {
            IntPtr cursorPtr;
            IntPtr ptr = bm.GetHicon();
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, ref tmp);
            tmp.xHotspot = xHotspot;
            tmp.yHotspot = yHotspot;
            tmp.fIcon = false;
            cursorPtr = CreateIconIndirect(ref tmp);

            if (tmp.hbmColor != IntPtr.Zero) DeleteObject(tmp.hbmColor);
            if (tmp.hbmMask != IntPtr.Zero) DeleteObject(tmp.hbmMask);
            if (ptr != IntPtr.Zero) DestroyIcon(ptr);

            return new Cursor(cursorPtr);
        }
        
    }
}