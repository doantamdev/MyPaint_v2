using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint_v2
{
    public class PatternRectangle : MyRectangle
    {


        protected Color _brushColor { get; set; }
        protected Color _borderColor { get; set; }


        public PatternRectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color colorFill,Color brushColor)
            : base(sPoint, ePoint, borderWidth, borderColor, colorFill)
        {
           _brushColor = brushColor;
            _borderColor = borderColor;
        }

        public override void Draw(Graphics g)
        {
           base.Draw(g);
            HatchBrush brush = new HatchBrush(HatchStyle.DarkVertical, _borderColor, _brushColor);
            RectangleF rect = new RectangleF(_location, new SizeF(_width, _height));
            g.FillRectangle(brush, rect);
        }
    }
}
