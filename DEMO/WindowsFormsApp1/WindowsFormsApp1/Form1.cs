using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "MouseEntered";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

            label1.Text = "MouseLeft";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "Mouse Down at " + e.X + " " + e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.Text = "Mouse Up at " + e.X + " " + e.Y;
        }
    }
}
