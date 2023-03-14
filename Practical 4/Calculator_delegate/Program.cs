using System;

namespace ArithmaticOperation
{
    class Program
    {
        delegate double ArithmaticDelegate(double a, double b);

        static void Menu()
        {
            Console.WriteLine("Select an arithmatic operation");
            Console.WriteLine("1)Addition");
            Console.WriteLine("2)Subtraction");
            Console.WriteLine("3)Multiplication");
            Console.WriteLine("4)Division");
            Console.WriteLine("5)Remainder");
            Console.WriteLine("6)Quit");
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static double Modulus(double a, double b)
        {
            return a % b;
        }

        static void Main(string[] args)
        {
            int operation;
            ArithmaticDelegate arithmatic = null;
            double n1, n2;

            do
            {
                Menu();
                operation = int.Parse(Console.ReadLine());
                if(operation!=6)
                {
                    Console.WriteLine("Enter two numbers");
                    n1 = double.Parse(Console.ReadLine());
                    n2 = double.Parse(Console.ReadLine());
                    switch (operation)
                    {
                        //Addition
                        case 1:
                            arithmatic = new ArithmaticDelegate(Add);
                            break;
                        //Subtraction
                        case 2:
                            arithmatic = new ArithmaticDelegate(Subtract);
                            break;
                        //Multiplication
                        case 3:
                            arithmatic = new ArithmaticDelegate(Multiply);
                            break;
                        //Division
                        case 4:
                            arithmatic = new ArithmaticDelegate(Divide);
                            break;
                        //Remainder
                        case 5:
                            arithmatic = new ArithmaticDelegate(Modulus);
                            break;
                        default:
                            Console.WriteLine("Exiting program");
                            break;
                    }
                    if (arithmatic != null)
                    {
                        Console.WriteLine("Answer is: " + arithmatic(n1, n2));
                    }
                } else
                {
                    break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                Console.Clear();

            } while (operation != 6);
        }
    }
}