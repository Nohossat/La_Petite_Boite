using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Ressources;
using System.IO;
using System.Drawing.Text;

namespace La_petite_boite
{
    public partial class tutoQueFaitLeRoi : PopForm
    {
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private bouton1 button1;
        private bouton1 button2;
        private Panel conteneurCarte;
        private Panel conteneurBouton;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Panel conteneurCarteAPlacer;
        
        List<Stream> audio = new List<Stream>();
        List<Bitmap> images = new List<Bitmap>();
        public int compteur = 0;

        public tutoQueFaitLeRoi() : base()
        {
            InitializeComponent();

            conteneur.Controls.Add(this.conteneurBouton);
            conteneur.Controls.Add(this.conteneurCarteAPlacer);
            conteneur.Controls.Add(this.conteneurCarte);

            this.conteneurCarte.Location = new Point(160, 230);
            this.conteneurCarteAPlacer.Location = new Point(160, 80);
            this.conteneurBouton.Location = new Point(160, 30);

            tableauFonctions.Add(action1);
            tableauFonctions.Add(action2);
            tableauFonctions.Add(action3);
            tableauFonctions.Add(action4);

            chargementPartie();

            System.Threading.Thread.Sleep(1000);
            timer2.Enabled = true;
        }
        
        private void chargementPartie()
        {
            audio.Add(items.roiRentreAuChateauFR);
            audio.Add(items.roiVaALecoleTurc);
            images.Add(items.ecole1);
            images.Add(items.chateau1);
            
            this.Enabled = true;

            button1.Tag = "1";
            button1.Text = petiteBoite.Textes[74];
            button2.Tag = "2";
            button2.Text = petiteBoite.Textes[75];

            pictureBox1.Image = items.chateau1;
            pictureBox2.Image = items.ecole1;

            foreach (PictureBox image in conteneurCarteAPlacer.Controls)
            {
                image.BorderStyle = BorderStyle.FixedSingle;
                image.Image = null;
                image.Enabled = true;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
            foreach (PictureBox image in conteneurCarte.Controls)
            {
                image.Visible = true;
                image.Enabled = true;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.BackColor = Color.White;
            }
            

            foreach (Button bouton in conteneurBouton.Controls)
            {
                bouton.Enabled = true;
            }
        }

        private void action1()
        {
            //on met la souris sur le premier bouton
            p.x = button1.Location.X + 200;
            p.y = button1.Location.Y + 140;

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);

            //on ecoute la premiere phrase
            Program.petiteBoite.JouerSon(audio.ElementAt(0));
        }

        private void action2()
        {
            pictureBox1.Cursor = Cursors.Hand;
            //on met la souris sur la premiere picturebox
            p.x = pictureBox1.Location.X + 230;
            p.y = pictureBox1.Location.Y + 400;

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);

            //on survole la premiere carte
            Program.petiteBoite.JouerSon(items.ecoleFR);
        }

        private void action3()
        {
            pictureBox2.Cursor = Cursors.Hand;
            //on met la souris sur la deuxieme picturebox
            p.x = pictureBox2.Location.X + 220;
            p.y = pictureBox2.Location.Y + 400;

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);
            //on survole la deuxieme carte
            Program.petiteBoite.JouerSon(items.chateauTurc);
        }

        private void action4()
        {
            //on met la souris sur l'emplacement
            p.x = pictureBox1.Location.X + 230;
            p.y = pictureBox1.Location.Y + 220;

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);

            //on met la bonne carte au bon emplacement
            conteneurCarteAPlacer.Controls.OfType<PictureBox>().ElementAt(0).Image = images[1];
            conteneurCarteAPlacer.Controls.OfType<PictureBox>().ElementAt(0).BackColor = Color.White;
            conteneurCarte.Controls.OfType<PictureBox>().ElementAt(0).Hide();
            Refresh();
        }
        
    }

    public class bouton1 : Button
    {
        public bouton1()
        {
            this.UseCompatibleTextRendering = true;
            this.TextRenderingHint = TextRenderingHint.AntiAlias;
            this.FlatAppearance.BorderSize = 0;
            this.TabStop = false;
            this.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            this.ForeColor = Color.White;
            this.BackColor = ColorTranslator.FromHtml("#b35344");
            this.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#770f00");
            this.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#770f00");
            this.FlatStyle = FlatStyle.Flat;
            this.Dock = DockStyle.None;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Cursor = Cursors.Hand;
            this.GotFocus += new EventHandler(myBtn_GotFocus);
            this.LostFocus += new EventHandler(myBtn_LostFocus);
        }

        private TextRenderingHint _textRenderingHint = TextRenderingHint.SystemDefault;

        public TextRenderingHint TextRenderingHint
        {
            get { return _textRenderingHint; }
            set { _textRenderingHint = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = _textRenderingHint;
            base.OnPaint(e);
        }

        private void myBtn_GotFocus(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = ColorTranslator.FromHtml("#770f00");
        }

        private void myBtn_LostFocus(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = ColorTranslator.FromHtml("#b35344");
        }

    }
}
