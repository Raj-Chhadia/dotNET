using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (string s in Enum.GetNames(typeof(KnownColor)))
                comboBox1.Items.Add(s);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(comboBox1.SelectedItem.ToString());
            listBox1.Items.Add(comboBox1.SelectedItem.ToString());
        }
    }
}
