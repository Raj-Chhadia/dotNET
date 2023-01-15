using System;

namespace Palindrome
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Palindrome checker");
            Console.WriteLine("Enter the string: ");
            string originalString = Console.ReadLine();
            char[] stringArray = originalString.ToCharArray();
            Array.Reverse(stringArray);
            string reverseString = new string(stringArray);

            if (reverseString.Equals(originalString))
                Console.WriteLine("String is Palindrome");
            else
                Console.WriteLine("String is not Palindrome");
            Console.Read();
        }
    }
}