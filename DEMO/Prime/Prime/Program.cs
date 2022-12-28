using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check");
            int number = int.Parse(Console.ReadLine());
            for(int i =2; i<number;i++)
            {
                if (number % i == 0)
                    Console.WriteLine("Number is not prime");    
                else
                    Console.WriteLine("Number is prime");
                break;
            }
            Console.ReadKey();
        }
    }
}
