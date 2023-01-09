using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Employee e1 = new Employee();
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("1. Student");
            Console.WriteLine("2. Employee");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case (1):
                    s1.getData();
                    s1.putData();
                    break;

                case (2):
                    e1.getData();
                    e1.putData();
                    break;
            }
            Console.ReadKey();
        }
    }

    class Information
    {
        public string name;
        public string surname;
        public int number;

        public void getData()
        {
            Console.WriteLine("Enter the first name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the surname: ");
            surname = Console.ReadLine();
            Console.WriteLine("Enter the contact number: ");
            number = int.Parse(Console.ReadLine());
        }
    }
    class Employee:Information
    {
        int salary;
        public void getData()
        {
            base.getData();
            Console.WriteLine("Enter the employee salary: ");
            salary = int.Parse(Console.ReadLine());  
        }
        public void putData()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("SurName: " + surname);
            Console.WriteLine("Contact Number: " + number);
            Console.WriteLine("Salary: " + salary);
        }
    }
    class Student:Information
    {
        int semester;

        public void getData()
        {
            base.getData();
            Console.WriteLine("Enter the semester number: ");
            semester = int.Parse(Console.ReadLine());
        }
        public void putData()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("SurName: " + surname);
            Console.WriteLine("Contact Number: " + number);
            Console.WriteLine("Semester: " + semester);
        }
    }
}
