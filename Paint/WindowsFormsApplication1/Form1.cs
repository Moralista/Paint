using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool press = false;
        Point Point;
        Point lastPoint;
        Graphics graphic;
        Pen pencil;

        public Form1()
        {
            InitializeComponent();
            graphic = panel1.CreateGraphics();
            pencil = new Pen(Color.Red);
        }

        private void paint()
        {
            graphic.DrawLine(pencil, lastPoint, Point);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Point = e.Location;
            press = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (press)
            {
                lastPoint = Point;
                Point = e.Location;
                paint();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            press = false;
        }
    }
}
