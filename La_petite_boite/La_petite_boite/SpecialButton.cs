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
    class SpecialButton : Button
    {
        public SpecialButton ()
        {
            this.Width = 1400;
            this.Height = 90;
            this.Anchor = AnchorStyles.None;
            this.ForeColor = ColorTranslator.FromHtml("#003255");
            this.BackColor = Color.Transparent;
            this.UseCompatibleTextRendering = true;
            this.TextRenderingHint = TextRenderingHint.AntiAlias;
            this.FlatAppearance.BorderSize = 0;
            this.TabStop = false;
            this.FlatAppearance.BorderColor = Color.FromArgb(0,255,255,255);
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.FlatStyle = FlatStyle.Flat;
            this.MouseEnter += new EventHandler(changeColorButton);
            this.MouseLeave += new EventHandler(PreviousColorButton);
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
}
