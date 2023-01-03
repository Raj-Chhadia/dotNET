using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of n numbers");
            Console.WriteLine("Enter value of n");
            int a = int.Parse(Console.ReadLine());
            int sum=0;
           
            for(int i=0;i<a;i++)
            {
                sum += a;
            }
            Console.WriteLine("Sum is: " + sum);
            Console.ReadKey();
        }
    }
    }

