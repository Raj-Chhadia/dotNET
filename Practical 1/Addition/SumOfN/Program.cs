using System;

namespace SumOfN
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Sum of n numbers");
            Console.WriteLine("Enter value of n");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= a; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum is: " + sum);
            Console.Read();
        }
    }
}