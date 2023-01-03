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
            s1.getData();
            s1.putData();

            Employee e1 = new Employee();
            e1.getData();
            e1.putData();
            Console.ReadKey();
        }
    }

    class Information
    {
        protected string name;
        protected string surname;
        protected int number;

        public void getData()
        {
        }
    }
    class Employee:Information
    {
        int salary;
        public void getData()
        {
            Console.WriteLine("Enter the employee salary: ");
            salary = int.Parse(Console.ReadLine());  
        }
        public void putData()
        {
            Console.WriteLine("Salary: " + salary);
        }
    }
    class Student:Information
    {
        int semester;

        public void getData()
        {
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the surname: ");
            surname = Console.ReadLine();
            Console.WriteLine("Enter the contact number: ");
            number = int.Parse(Console.ReadLine());
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
