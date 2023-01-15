using System;

namespace ElectricityBill
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Electricity Bill Calaculator");
            Console.WriteLine("Enter number of units consumed: ");
            float a = float.Parse(Console.ReadLine());
            if (a > 0 && a <= 100)
                Console.WriteLine("Bill amount is : " + (a * 5));
            else if (a >= 100 && a < 200)
                Console.WriteLine("Bill amount is : " + (a * 10));
            else if (a >= 200 && a < 300)
                Console.WriteLine("Bill amount is : " + (a * 20));
            else if (a >= 300 && a < 400)
                Console.WriteLine("Bill amount is : " + (a * 30));
            else if (a >= 400 && a < 500)
                Console.WriteLine("Bill amount is : " + (a * 40));
            else
                Console.WriteLine("Bill amount is : " + (a * 50));
            Console.Read();
        }
    }
}