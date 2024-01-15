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

        private Graphics _graphic;
        private Point _aPoint;
        private Point _sPoint;
        private bool _moving;
        private Color _penColorBorder = Color.Black;
        private Color _penColorInSide = Color.White;
        private LinkedList<MyRectangle> _rectangles;
        public Form1()
        {
            InitializeComponent();

            _graphic = mainPanel.CreateGraphics();
            _aPoint = new Point(-1, -1);
            _sPoint = new Point(-1, -1);
            _moving = false;
            _rectangles = new LinkedList<MyRectangle>();
        

        }
   

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _sPoint = e.Location;
            _moving = true;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_moving || (_sPoint == _aPoint)) { return; }
            RefreshPanel();
            int penWidth = (int)inpPenWidth.Value;
            if(!ckbColor.Checked)
            {
                _penColorInSide = Color.White;
            }
            MyRectangle rect = new MyRectangle(_sPoint, e.Location, penWidth, _penColorBorder);
            rect.FillColor = _penColorInSide;
            rect.Draw(_graphic);
           
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            int penWidth = (int)inpPenWidth.Value;
            MyRectangle rect = new MyRectangle(_sPoint, e.Location, penWidth, _penColorBorder);
            rect.FillColor = _penColorInSide;
            _rectangles.AddLast(rect);
            _sPoint.X = -1;
            _sPoint.Y = -1;
            _moving = false;

        }

        private void RefreshPanel()
        {
            _graphic.Clear(Color.White);
            foreach (MyRectangle rect in _rectangles)
            {
                rect.Draw(_graphic);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cdPenColor.ShowDialog();
            Color color = cdPenColor2.Color;
            _penColorBorder = cdPenColor2.Color;
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            cdPenColor2.ShowDialog();
            Color color = cdPenColor2.Color;
            _penColorInSide = cdPenColor2.Color;
        }
    }
}
