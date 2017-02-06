using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace La_petite_boite
{
    public class bouton : Button
    {
        public bouton ()
        {
            this.UseCompatibleTextRendering = true;
            this.TextRenderingHint = TextRenderingHint.AntiAlias;
            this.FlatAppearance.BorderSize = 0;
            this.TabStop = false;
            this.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            this.ForeColor = Color.Chocolate;
            this.BackColor = Color.Transparent;
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.FlatStyle = FlatStyle.Flat;
            this.Dock = DockStyle.None;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Cursor = Cursors.Hand;
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
            this.BackColor = ColorTranslator.FromHtml("#95c464");
            this.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#95aa52");
            this.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#95aa52");
            this.Font = new Font(petiteBoite.fontPopUp.Families[0], 9);
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
            b.BackColor = ColorTranslator.FromHtml("#95aa52");
        }

        private void myBtn_LostFocus(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = ColorTranslator.FromHtml("#95c464");
        }

        public void gotFocus()
        {
            this.BackColor = ColorTranslator.FromHtml("#95aa52");
        }

    }

    public class SpecialButton : bouton
    {
        public String previousColor;
        public String afterColor;

        public SpecialButton(String prev, String after, int width, int height)
        {
            //pour les gros boutons
            //width = 500
            //height = 90

            //pour les petits boutons
            // width = 200
            // height = 70
            this.Width = width;
            this.Height = height;
            this.previousColor = prev;
            this.afterColor = after;
            this.ForeColor = ColorTranslator.FromHtml(previousColor);
            this.MouseEnter += new EventHandler(changeColorButton);
            this.MouseLeave += new EventHandler(PreviousColorButton);
        }

        private void PreviousColorButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = ColorTranslator.FromHtml(previousColor);
        }

        private void changeColorButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = ColorTranslator.FromHtml(afterColor);
        }
    }
    
    public class LittleButton : bouton
    {
        public LittleButton(int top)
        {
            this.Width = 150;
            this.Height = 45;
            this.Top = top;
            this.MouseEnter += new EventHandler(changeColorButton);
            this.MouseLeave += new EventHandler(PreviousColorButton);
        }

        private void PreviousColorButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            b.ForeColor = Color.Chocolate;
        }

        private void changeColorButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            b.ForeColor = Color.Brown;
        }
        
    }

    public class popUpButton : bouton
    {
        public popUpButton()
        {
            this.Top = 0;
            this.BackColor = ColorTranslator.FromHtml("#e9dce3");
            this.ForeColor = ColorTranslator.FromHtml("#003255");
            this.FlatAppearance.MouseDownBackColor = Color.White;
            this.FlatAppearance.MouseOverBackColor = Color.White;
        }
    }

    public class CustomButton1 : UserControl
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black, 2);

            Rectangle rect = Rectangle.Round(new Rectangle(630, 200, 100, 50));
            g.DrawRectangle(myPen, rect);

            myPen.Dispose();

        }
    }

    public class SpecialLabel : Label
    {
        public SpecialLabel()
        {
            this.UseCompatibleTextRendering = true;
            this.AutoSize = false;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Dock = DockStyle.None;
            this.TextRenderingHint = TextRenderingHint.AntiAlias;
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
    }


}
