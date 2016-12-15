using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_petite_boite
{
    class ControlButton : Button
    {
        public ControlButton () {
            this.Width = 200;
            this.Height = 70;
            this.Top = 590;
            this.FlatAppearance.BorderSize = 0;
            this.TabStop = false;
            this.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = SystemColors.ControlLightLight;
            this.BackColor = Color.Transparent;
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.UseCompatibleTextRendering = true;
            this.AutoSize = false;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Dock = DockStyle.None;
            this.TextRenderingHint = TextRenderingHint.AntiAlias;
            this.MouseEnter += new EventHandler(changeColorButton);
            this.MouseLeave += new EventHandler(PreviousColorButton);
        }
        
        private void PreviousColorButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            b.ForeColor = SystemColors.ControlLightLight;
        }

        private void changeColorButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            b.ForeColor = ColorTranslator.FromHtml("#6d5622");
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

    public class LittleButton : Button
    {
        public LittleButton(int top)
        {
            this.Width = 150;
            this.Height = 45;
            this.Top = top;
            this.FlatAppearance.BorderSize = 0;
            this.TabStop = false;
            this.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = Color.Chocolate;
            this.BackColor = Color.Transparent;
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.UseCompatibleTextRendering = true;
            this.AutoSize = false;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Dock = DockStyle.None;
            this.TextRenderingHint = TextRenderingHint.AntiAlias;
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
