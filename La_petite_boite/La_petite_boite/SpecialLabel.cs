﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_petite_boite
{
    public class SpecialLabel : Label
    {
        public SpecialLabel ()
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
