using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_datavase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string conn_str = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Demodb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(conn_str);
            string sql = @"INSERT INTO employee VALUES (" + txt1.Text + ", '" + txt2.Text + "', '" + txt3.Text + "','" + txt4.Text + "'," + txt5.Text + ");";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Inserted");
            }
            catch(Exception err)
            {
                MessageBox.Show(""+err);
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string conn_str = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Demodb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(conn_str);
            string sql = @"SELECT name,designation,department,salary from employee where emp_id=" + txt1.Text+"";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt2.Text = dr.GetValue(0).ToString();
                    txt3.Text = dr.GetValue(1).ToString();
                    txt4.Text = dr.GetValue(2).ToString();
                    txt5.Text = dr["salary"].ToString();
                }
                dr.Close();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("" + err);
            }
        }
    }
}
