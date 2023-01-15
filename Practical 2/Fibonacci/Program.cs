using System;

namespace Fibonacci
{
    internal class Program
    {
        public static int Fibonacci(int n)
        {
            if (n == 1)
                return 0;
            else if (n == 2)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Fibbonacci Series");
            Console.WriteLine("Enter nth term: ");
            int number = int.Parse(Console.ReadLine());
            int term = Fibonacci(number);
            Console.WriteLine("nth term is: " + term);
            Console.Read();
        }
    }
}