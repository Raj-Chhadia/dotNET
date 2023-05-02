using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Student_Form
{
    public partial class Form1 : Form
    {
        string name,en,email,mob,sem,gender,dob;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            Process.Start("notepad");
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            bt1.FlatStyle = FlatStyle.System;
            name = txt1.Text; 
            en = txt2.Text;
            email = txt3.Text;
            mob = txt4.Text;
            sem = cmb1.SelectedItem.ToString();
            if (rd1.Checked)
                gender = rd1.Text;
            else
                gender = rd2.Text;
            dob = dtp1.Text;    
            MessageBox.Show("Name: "+name+"\nEnrollment No: "+en+"\nEmail:"+email+"\nMobile Number:" +mob+"\nSemester: "+sem+"\nGender: "+gender+"\nDOB:"+dob);
        }
    }
}
