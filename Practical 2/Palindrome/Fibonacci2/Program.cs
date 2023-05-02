//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Fibonacci2
//{
//    class Program
//    {
//        public static void Fibonacci(int num1, int num2, int count, int n)
//        {
//            Console.Write(num1 + " ");
//            if (count < n)
//            {
//                Fibonacci(num2, num1 + num2, count + 1, n);
//            } 
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("-----Printing fibonacci series-----");
//            Console.WriteLine("Enter n:");
//            int n = int.Parse(Console.ReadLine());
//            Fibonacci(0, 1, 1, n);
//            Console.ReadKey();
//        }
//    }
//}
using System;
namespace Fibonacci2
{
    class FibonacciSeries
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter the number of terms to display in the Fibonacci series:");
            int terms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci series:");
            for (int i = 0; i < terms; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.ReadKey();
        }
    }
}

