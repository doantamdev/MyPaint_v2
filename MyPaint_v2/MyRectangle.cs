using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint_v2
{
    public class MyRectangle : Shape
    {
        protected int _width;
        protected int _height;
        protected Color _colorFill;


        public MyRectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color bgColor)
             : base(sPoint, ePoint, borderWidth, borderColor, bgColor)
        {
            _width = ePoint.X - sPoint.X;
            _height = ePoint.Y - sPoint.Y;
            _borderColor = borderColor;
            _borderWidth = borderWidth;
            _colorFill = bgColor;
        }


        public override void Draw(Graphics g)
        {
            Pen p = new Pen(_borderColor, _borderWidth);
            Rectangle rect = new Rectangle(_location, new Size(_width, _height));
            if (_colorFill != Color.Empty)
            {
                using (Brush brush = new SolidBrush(_colorFill))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            g.DrawRectangle(p, rect);
        }
    }
}
