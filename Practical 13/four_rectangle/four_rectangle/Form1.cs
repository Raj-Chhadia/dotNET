using System;
using System.Drawing;
using System.Windows.Forms;

namespace four_rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Define the rectangle
            Rectangle rectangle = new Rectangle(10, 10, 200, 100);

            // Define the pens for each side
            Pen leftPen = new Pen(Color.Red, 5);
            Pen topPen = new Pen(Color.Green, 5);
            Pen rightPen = new Pen(Color.Blue, 5);
            Pen bottomPen = new Pen(Color.Yellow, 5);

            // Draw the rectangle with the multicolor sides
            g.DrawLine(leftPen, rectangle.Left, rectangle.Top, rectangle.Left, rectangle.Bottom);
            g.DrawLine(topPen, rectangle.Left, rectangle.Top, rectangle.Right, rectangle.Top);
            g.DrawLine(rightPen, rectangle.Right, rectangle.Top, rectangle.Right, rectangle.Bottom);
            g.DrawLine(bottomPen, rectangle.Left, rectangle.Bottom, rectangle.Right, rectangle.Bottom);

            // Dispose the pens
            leftPen.Dispose();
            topPen.Dispose();
            rightPen.Dispose();
            bottomPen.Dispose();
        }
    }
}
