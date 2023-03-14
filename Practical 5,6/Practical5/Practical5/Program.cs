using System;
using System.Data.SqlClient;

namespace Practical5
{
    class Database
    {
        string connection_str = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void create()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connection_str);
                conn.Open();
                Console.WriteLine("Connection Established!!");
                string sql = @"create table employee (Emp_id int IDENTITY(1,1) PRIMARY KEY , Name varchar(30), Designation varchar(30), Department varchar(30), Salary int)";
                SqlCommand command = new SqlCommand(sql, conn);
                Console.WriteLine("Table Created");
                command.ExecuteNonQuery();
                command.Dispose();
                conn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Table already existing in database!!!");
            }
        }

        public void insert()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connection_str);
                conn.Open();
                Console.WriteLine("Connection Established!!");
                string sql = @"INSERT INTO employee ( Name, Designation, Department, Salary) VALUES ('Raj', 'Manager', 'Sales', 35000);  
                               insert into employee(Name, Designation, Department, Salary) values('Priya', 'Manager', 'HR', 30000);
                               insert into employee(Name, Designation, Department, Salary) values('Manoj', 'Driver', 'Transport', 15000);
                               insert into employee(Name, Designation, Department, Salary) values('Aakash', 'Executive', 'Finance', 85000); ";
                SqlCommand command = new SqlCommand(sql, conn);
                Console.WriteLine("Rows inserted");
                command.ExecuteNonQuery();
                command.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void read()
        {
            try
            {
                string output = "";
                SqlConnection conn = new SqlConnection(connection_str);
                conn.Open();
                //string sql = "SELECT * FROM employee";
                string sql = "SELECT * FROM employee WHERE Emp_id=1";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader dataReader = command.ExecuteReader();
                Console.Write(format("Emp_id") + format("Name")+ format("Designation")+ format("Department")+ format("Sales") + "\n" );
                while (dataReader.Read())
                {
                    output = output + format(dataReader.GetValue(0).ToString()) + format(dataReader.GetValue(1).ToString()) + format(dataReader.GetValue(2).ToString()) + format(dataReader.GetValue(3).ToString()) + format(dataReader.GetValue(4).ToString()) + "\n";
                }
                Console.Write(output);
                dataReader.Close();
                command.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void delete()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connection_str);
                conn.Open();
                Console.WriteLine("Connection Established!!");
                string sql = @"TRUNCATE TABLE employee;";
                SqlCommand command = new SqlCommand(sql, conn);
                Console.WriteLine("Table Created");
                command.ExecuteNonQuery();
                command.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static public string format(string str)
        {
            const int SIZE = 15;
            for(int i=str.Length; i<=SIZE; i++)
            {
                str += " ";
            }
            return str;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Database db1 = new Database();
            //Console.WriteLine("Creating a table");
            //db1.create();
            Console.WriteLine("Inserting into a table");
            db1.insert();
            Console.WriteLine("Reading a table");
            db1.read();
            //Console.WriteLine("Deleting all entries");
            //db1.delete();
            //Console.WriteLine("Reading a table");
            //db1.read();

            Console.ReadKey();
        }
    }
}
