using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace student_db_gridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn_str = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Demodb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(conn_str);
            string sql = @"SELECT * from employee";     
            DataTable dt = null;

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

        private void button2_Click(object sender, EventArgs e)
        {
            string conn_str = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Demodb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(conn_str); 
            conn.Open();
            // Allow the user to add new rows to the DataGridView
            dataGridView1.AllowUserToAddRows = true;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM employee", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update((DataTable)dataGridView1.DataSource);
            conn.Close();
        }
    }
}
