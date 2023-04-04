using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Student_datavase
{
    public partial class Form1 : Form
    {
        int cr = 0;
        int rowCount;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string conn_str = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Demodb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(conn_str);
            string sql = @"INSERT INTO employee VALUES ( '" + txt2.Text + "', '" + txt3.Text + "','" + txt4.Text + "'," + txt5.Text + ");";
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
            string sql = @"SELECT * from employee";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            rowCount = dt.Rows.Count;
            try
            {
                conn.Open();
                da.Fill(dt);
                da.Dispose();
                Load();
               
            }
            catch (Exception err)
            {
                MessageBox.Show("" + err);
            }
        }
        private void Load()
        {
            DataRow dr = dt.Rows[cr];
            txt1.Text = dr["emp_id"].ToString();
            txt2.Text = dr["Name"].ToString();
            txt3.Text = dr["Designation"].ToString();
            txt4.Text = dr["Department"].ToString();
            txt5.Text = dr["salary"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cr - 1 >= 0)
                cr -= 1;
            Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cr + 1 < rowCount)
                cr += 1;
            Load();
        }
    }
}
