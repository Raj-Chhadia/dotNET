using System;

namespace Reverse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Reversal of array");
            Console.WriteLine("Enter the number of element : ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] original_array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Array[{0}] :", i);
                original_array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Reverse(original_array);
            for (int i = 0; i < size; i++)
            {
                Console.Write("Reverse array is :");
                Console.WriteLine(original_array[i]);
            }
            Console.Read();
        }
    }
}