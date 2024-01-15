using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint_v2
{
    internal class MyRectangle
    {
        public Point location;
        public int width;
        public int height;
        public int bordersWidth;
        public Color borderColor;
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public int BordersWidth { get; set; }
        public Color BorderColor { get; set; }

        public bool IsColor { get; set; }

        public Color FillColor { get; set; } = Color.Empty;

        public MyRectangle()
        {

        }

        public MyRectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor)
        {
            StartPoint = sPoint;
            EndPoint = ePoint;
            BordersWidth = borderWidth;
            BorderColor = borderColor;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(BorderColor, BordersWidth);
            Rectangle rect = new Rectangle(StartPoint.X, StartPoint.Y, EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y);

            {
                if (FillColor != Color.Empty)
                {
                    using (Brush brush = new SolidBrush(FillColor))
                    {
                        g.FillRectangle(brush, rect);
                    }
                }

                g.DrawRectangle(pen, rect);
            }
        }
    }
}
