using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint_v2
{
    public abstract class Shape
    {
        protected Point _location;
        protected int _borderWidth;
        protected Color _borderColor;
        protected Color _bgColor;
        protected Color _bgColorFill;

        public Shape(Point sPoint, Point ePoint, int boderWidth, Color borderColor,Color colorFill)
        {
            _location = sPoint;
            _borderWidth = boderWidth;
            _borderColor = borderColor;      
            _bgColorFill = colorFill;
        }

        public abstract void Draw(Graphics g);
    }
}
