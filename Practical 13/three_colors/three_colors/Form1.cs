using System;
using System.Drawing;
using System.Windows.Forms;

namespace three_colors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // red line
            Pen redPen = new Pen(Color.Red, 3);
            Point startPoint1 = new Point(10, 10);
            Point endPoint1 = new Point(100, 10);
            g.DrawLine(redPen, startPoint1, endPoint1);

            // green line
            Pen greenPen = new Pen(Color.Green, 5);
            Point startPoint2 = new Point(10, 50);
            Point endPoint2 = new Point(150, 50);
            g.DrawLine(greenPen, startPoint2, endPoint2);

            // blue line
            Pen bluePen = new Pen(Color.Blue, 7);
            Point startPoint3 = new Point(10, 100);
            Point endPoint3 = new Point(200, 100);
            g.DrawLine(bluePen, startPoint3, endPoint3);
        }
    }
}
