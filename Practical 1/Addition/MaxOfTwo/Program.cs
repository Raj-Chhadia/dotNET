using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max of two numbers");
            Console.WriteLine("Enter 1st INTEGER");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd INTEGER");
            int b = int.Parse(Console.ReadLine());
            if(a>b)
                Console.WriteLine("Max is : " + a);
            else if(b>a)
                Console.WriteLine("Max is: " + b);
            else
                Console.WriteLine("Both are equal");
            Console.ReadKey();
        }
    }
    }

