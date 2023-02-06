namespace Addition
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Addtion of two numbers");
            Console.WriteLine("Enter 1st INTEGER");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd INTEGER");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;

            Console.WriteLine("Answer: " + c);
            Console.Read();
        }
    }
}
