using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForm_color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Aqua;
            label1.ForeColor = Color.Red;
            label1.Font = new Font("Arial", 30, FontStyle.Italic);
        }
    }
}
