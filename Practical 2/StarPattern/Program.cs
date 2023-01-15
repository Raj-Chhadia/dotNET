using System;

internal class HelloWorld
{
    private static void Main()
    {
        Console.WriteLine("Enter the number : ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            for (int j = number - i; j > 0; j--)
            {
                Console.Write(number - i);
            }
            Console.WriteLine("\n");
        }
        Console.Read();
    }
}