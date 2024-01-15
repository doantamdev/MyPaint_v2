using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint_v2
{
    internal class MyCircle : Shape
    {
        private float _radius;
        public MyCircle(Point sPoint, Point ePoint, int borderWidth, Color borderColor)
            : base(sPoint, ePoint, borderWidth, borderColor)
        {
            _radius = sPoint.X;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(_borderColor, _borderWidth);

            SizeF size = new SizeF(_radius, _radius);
            RectangleF cirle = new RectangleF(_location, size);

            SolidBrush brush = new SolidBrush(_bgColor);

            if (_isPattern)
            {
                HatchBrush hatchBrush = new HatchBrush(HatchStyle.LargeGrid, _borderColor, _borderColor);
                //g.FillRectangle(hatchBrush, rect);
            }

            g.FillEllipse(brush, cirle);
            g.DrawEllipse(pen, cirle);
        }
    }
}
