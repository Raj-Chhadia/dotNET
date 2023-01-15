using System;

namespace Calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("Enter operation (+.-,*,/): ");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter 1st number: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            float b = float.Parse(Console.ReadLine());
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Addition of two number is: " + (a + b));
                    break;

                case "-":
                    Console.WriteLine("Subtraction of two number is: " + (a - b));
                    break;

                case "*":
                    Console.WriteLine("Multiplication of two number is: " + (a * b));
                    break;

                case "/":
                    Console.WriteLine("Division of two number is: " + (a / b));
                    break;

                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
            Console.Read();
        }
    }
}