using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace _11._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cr = 0;
        DataTable dt=null;
        private void Form1_Load(object sender, EventArgs e)
        {
            cr = 0;
            dt = new DataTable();
            string connstring = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Demodb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                string query = @"select * from employee;";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                try
                {
                    conn.Open();
                    da.Fill(dt);
                    da.Dispose();
                    LoadRow();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void LoadRow()
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
            LoadRow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cr + 1 < dt.Rows.Count)
                cr += 1;
            LoadRow();
        }
    }
}
