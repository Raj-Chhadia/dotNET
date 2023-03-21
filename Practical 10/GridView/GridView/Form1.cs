using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace GridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string conn_str = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Demodb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(conn_str);
            string sql = @"SELECT name,designation,department,salary from employee where emp_id=1;";
            //SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt=null;

            SqlDataAdapter da;
            try
            {
                conn.Open();
                dt = new DataTable();
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                da.Dispose();
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("" + err);
            }
        }
    }
}
