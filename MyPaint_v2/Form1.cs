using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyPaint_v2
{
    public partial class Form1 : Form
    {
        protected Graphics _graphic;
        protected Point _aPoint;
        protected Point _sPoint;
        protected bool _moving;
        protected Color _penColorBorder = Color.Black;
        protected Color _penColorInSide = Color.Empty;
        protected Color _penColorBrush = Color.Black;
        protected LinkedList<Shape> _shapes;

        public Form1()
        {
            InitializeComponent();
            _graphic = mainPanel.CreateGraphics();
            _aPoint = new Point(-1, -1);
            _sPoint = new Point(-1, -1);
            _moving = false;
            _shapes = new LinkedList<Shape>();

        }


        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _sPoint = e.Location;
            _moving = true;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_moving || (_sPoint == _aPoint))
            {
                return;
            }

            RefreshPanel();

            Shape s = GetShape(e.Location);
            //MessageBox.Show(s.ToString());
            s.Draw(_graphic);
        }
        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Shape s = GetShape(e.Location);
            _shapes.AddLast(s);

            _sPoint.X = -1;
            _sPoint.Y = -1;
            _moving = false;
        }

        private void RefreshPanel()
        {
            _graphic.Clear(Color.White);

            foreach (Shape s in _shapes)
            {
              s.Draw(_graphic);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cdPenColor.ShowDialog();
            Color color = cdPenColor.Color;
            _penColorBorder = cdPenColor.Color;
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            cdPenColorInside.ShowDialog();
            Color color = cdPenColorInside.Color;
            _penColorInSide = cdPenColorInside.Color;
        }

        private void btnColor3_Click(object sender, EventArgs e)
        {
            cdBrushColor.ShowDialog();
            Color color = cdBrushColor.Color;
            _penColorBrush = cdBrushColor.Color;
        }

        public Shape GetShape(Point ePoint)
        {
            int penWidth = (int)inpPenWidth.Value;
            if (!ckbColor.Checked)
            {
                _penColorInSide = Color.Empty;
            }

            Shape s ;

            if (rbRectangle.Checked)
            {
                if (rbNoFill.Checked)
                {
                    s = new MyRectangle(_sPoint, ePoint, penWidth, _penColorBorder, _penColorInSide);
                }
                else if (rbColorFill.Checked)
                {
                    s = new MyRectangle(_sPoint, ePoint, penWidth, _penColorBorder, _penColorInSide);

                }
                else
                {                 
                    s = new PatternRectangle(_sPoint, ePoint, penWidth, _penColorBorder, _penColorInSide, _penColorBrush);
                }
            }
            else
            {
                if (rbNoFill.Checked)
                {
                    s = new MyCircle(_sPoint, ePoint, penWidth, _penColorBorder, _penColorInSide);
                }
                else if (rbColorFill.Checked)
                {
                    s = new MyCircle(_sPoint, ePoint, penWidth, _penColorBorder, _penColorInSide);
                }
                else
                {               
                    s = new PatternCircle(_sPoint, ePoint, penWidth, _penColorBorder, _penColorInSide, _penColorBrush);
                }
            }

            return s;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine();
        }
    }
}
