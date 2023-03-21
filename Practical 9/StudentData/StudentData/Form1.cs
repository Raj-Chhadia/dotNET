using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentData
{
    public partial class Form1 : Form
    {
        string gender;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            string tc = chk_tc.Checked.ToString();
            string conn_str = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Demodb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(conn_str);
            string sql = @"INSERT INTO student VALUES ('" + txt1.Text + "', " + txt2.Text + ", '" + txt3.Text + "'," + txt4.Text + "," + cmb1.SelectedItem.ToString() + ",'" + gender + "','" + dtp1.Text + "','" + tc + "');";
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            if (rd1.Checked)
                gender = rd1.Text;
            else
                gender = rd2.Text;
            if (chk_tc.Checked == true)
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Records Inserted!");
                }
                catch (Exception err)
                {
                    MessageBox.Show(""+err);
                }
            }
            else
            {
                MessageBox.Show("Accept T&C!");
            }

            }
    }
}
