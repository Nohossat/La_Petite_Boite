using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
using System.Diagnostics;
using Ressources;
using System.Drawing.Text;

namespace La_petite_boite
{
    public partial class recompense1 : Form
    {
        public recompense1()
        {
            InitializeComponent();
        }
    }

    public partial class recompense : Panel
    {
        public List<PictureBox> etoilesRecompenses = new List<PictureBox>();
        public PictureBox coloriage1 = new PictureBox();
        public PictureBox coloriage2 = new PictureBox();
        public PictureBox video = new PictureBox();
        bouton retourButton = new bouton();
        delegate void actionButton(object sender, EventArgs e);
        List<actionButton> tableauFonctions = new List<actionButton>();
        int compteur = 0;
        Double largeur;
        Double longueur;

        public recompense(PrivateFontCollection pfc)
        {
            initialize();
            Double Left;
            this.BackgroundImage = items.recompenses;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Size = new Size(1273, 689);
            this.Anchor = AnchorStyles.None;
            this.Dock = DockStyle.Fill;
            Left = 0.77 * this.Width;
            retourButton.Click += new EventHandler(retour);
            retourButton.MouseEnter += new EventHandler(PreviousColorButton);
            retourButton.MouseLeave += new EventHandler(ChangeColorButton);
            retourButton.BackgroundImage = items.fondRecompenseAfter;
            retourButton.BackColor = Color.Transparent;
            retourButton.BackgroundImageLayout = ImageLayout.Stretch;
            retourButton.ForeColor = Color.White;
            retourButton.Text = "Retour vers la Carte";
            retourButton.Font = new Font(pfc.Families[0], 22);
            retourButton.Location = new Point((int) Left, -2);
            retourButton.Size = new Size(300,71);
            this.Controls.Add(retourButton);

            etoilesRecompenses.Add(coloriage1);
            etoilesRecompenses.Add(coloriage2);
            etoilesRecompenses.Add(video);

            tableauFonctions.Add(chanson);
            tableauFonctions.Add(coloriageEvent1);
            tableauFonctions.Add(coloriageEvent2);

            foreach (PictureBox p in etoilesRecompenses)
            {
                p.Cursor = Cursors.Hand;
                p.Image = items.etoileCoffre;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Size = new Size(139, 131);
                p.BackColor = Color.Transparent;
                p.Click += new EventHandler(tableauFonctions[compteur]);
                p.MouseEnter += new EventHandler(etoileAfter);
                p.MouseLeave += new EventHandler(etoilePrevious);
                this.Controls.Add(p);
                compteur++;
            }

            largeur = 0.55 * this.Width;
            longueur = 0.21 * this.Height;
            coloriage1.Location = new Point((int)largeur, (int) longueur);
            largeur = 0.17 * this.Width;
            longueur = 0.37 * this.Height;
            coloriage2.Location = new Point((int)largeur, (int)longueur);
            largeur = 0.49 * this.Width;
            longueur = 0.43 * this.Height;
            video.Location = new Point((int)largeur, (int)longueur);
        }

        private void etoileAfter(object sender, EventArgs e)
        {
            PictureBox etoile = (PictureBox)sender;

            etoile.Image = items.etoileCoffreHover;
        }

        private void etoilePrevious(object sender, EventArgs e)
        {
            PictureBox etoile = (PictureBox)sender;

            etoile.Image = items.etoileCoffre;
        }

        private void chanson(object sender, EventArgs e)
            {
                Process.Start("OtobusunTekerlegniYuvarlak.avi");
            }

        private void coloriageEvent1 (object sender, EventArgs e)
            {
                Process.Start("coloriage1.gif");
            }

        private void coloriageEvent2 (object sender, EventArgs e)
            {
                Process.Start("coloriage2.gif");
            }

        private void retour(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Hide();
        }

        private void PreviousColorButton(object sender, EventArgs e)
        {
            bouton b = (bouton)sender;

            b.BackgroundImage = items.fondRecompense;
        }

        private void ChangeColorButton(object sender, EventArgs e)
        {
            bouton b = (bouton)sender;

            b.BackgroundImage = items.fondRecompenseAfter;
        }


    }
}

