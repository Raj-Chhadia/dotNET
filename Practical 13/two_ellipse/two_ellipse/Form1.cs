using System;
using System.Drawing;
using System.Windows.Forms;

namespace two_ellipse
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

            // first ellipse
            Rectangle ellipse1Rect = new Rectangle(50, 50, 100, 200);
            g.DrawEllipse(Pens.Red, ellipse1Rect);

            // second ellipse
            Rectangle ellipse2Rect = new Rectangle(200, 100, 200, 100);
            g.DrawEllipse(Pens.Green, ellipse2Rect);
        }
    }
}
