using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint_v2
{
    public class PatternCircle : MyCircle
    {
        private float _radius;
        protected Color _brushColor { get; set; }
        protected Color _borderColor { get; set; }
        public PatternCircle(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color colorFill, Color brushColor)
            : base(sPoint, ePoint, borderWidth, borderColor, colorFill)
        {
            //_radius = (float)Math.Sqrt(Math.Pow(ePoint.X - sPoint.X, 2) + Math.Pow(ePoint.Y - sPoint.Y, 2)) / 2;
            _radius =sPoint.X;
            _brushColor=brushColor;
            _borderColor =borderColor;
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            HatchBrush brush = new HatchBrush(HatchStyle.DiagonalCross, _borderColor, _brushColor);
            RectangleF circle = new RectangleF(_location, new SizeF(_radius, _radius));
            g.FillEllipse(brush, circle);
        }
    }
}
