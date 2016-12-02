using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_petite_boite
{
    public class CustomButton1 : UserControl
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black, 2);

            Rectangle rect = Rectangle.Round(new Rectangle(630, 200, 100, 50));
            g.DrawRectangle(myPen,rect);

            myPen.Dispose();

        }
    }
}
