namespace Demo
{
    using System;
    using System.Data.SqlClient;

    class Connection
    {
        static void connect() 
        {
            string connection_string = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Demodb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            try
            {
                //string connection_string = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Demodb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection conn = new SqlConnection(connection_string);
                conn.Open();
                Console.WriteLine("Connection Established!!");
                string sql = "insert into demo values (61,'Python')";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                conn.Close();
                displaydata(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void displaydata(SqlConnection conn)
        {
            string output = "";
            conn.Open();
            string select = "SELECT * FROM demo";
            SqlCommand command = new SqlCommand(select,conn);
            SqlDataReader dataReader = command.ExecuteReader();
            while(dataReader.Read())
            {
              output = output + "\t" + dataReader.GetValue(0) + "\t" + dataReader.GetValue(1) + "\n";
            }
            dataReader.Close();
            command.Dispose();
            conn.Close();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***************Database Demo*************/");
            connect();
            Console.ReadLine();
        }
       /*
        public void Insert()
        {
        string sql = "insert into demo values (3,'Java')";
        }

        public void select()
        {
            string sql = "SELECT * from emp";
            SqlCommand command = new SqlCommand(sql, conn);
        }
       */
    }
}

//Data Source = (localdb)\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False