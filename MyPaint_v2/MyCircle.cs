using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint_v2
{
    public class MyCircle : Shape
    {
        private float _radius;
        protected int _width;
        protected int _height;
        protected int _bordersWidth;
        protected Color _colorFill;
        public MyCircle(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color colorFill)
            : base(sPoint, ePoint, borderWidth, borderColor, colorFill)
        {
            _radius =sPoint.X;
            _bordersWidth = borderWidth;
            _borderColor = borderColor;
            _colorFill = colorFill;
        }

       

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(_borderColor,_borderWidth);
            RectangleF circle = new RectangleF(_location, new SizeF(_radius, _radius));
            if (_colorFill != Color.Empty)
            {
                using (Brush brush = new SolidBrush(_colorFill))
                {
                    g.FillEllipse(brush, circle);
                }
            }
            g.DrawEllipse(p, circle);
        }
    }
}
