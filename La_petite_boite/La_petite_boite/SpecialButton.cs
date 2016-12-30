using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ressources;

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

    public class SpecialButton : bouton
    {
        public SpecialButton()
        {
            this.Width = 500;
            this.Height = 90;
            this.ForeColor = ColorTranslator.FromHtml("#003255");
            this.MouseEnter += new EventHandler(changeColorButton);
            this.MouseLeave += new EventHandler(PreviousColorButton);
        }
        
        private void PreviousColorButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = ColorTranslator.FromHtml("#003255");
        }

        private void changeColorButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = Color.Brown;
            //b.ForeColor = ColorTranslator.FromHtml("#a14e6d");
        }
    }

    public class ControlButton : bouton
    {
        String previousColor;
        String afterColor;
        public ControlButton(String prev, String after) : base()
        {
            this.Width = 200;
            this.Height = 70;
            this.Top = 590;
            this.previousColor = prev;
            this.afterColor = after;
            this.ForeColor = ColorTranslator.FromHtml(prev);
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

    
}
