using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Grade checker ==========");
            int[] marks = new int[5];
            int number = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the subject " + (i+1) + " marks");
                marks[i] = int.Parse(Console.ReadLine());
                number += marks[i];

            }
            float percent = (number / 5);
            Console.WriteLine("Your total marks is " + number);
            Console.WriteLine("Your percentage is " + percent + "%");

            
            if (percent <  33)
                Console.WriteLine("ypu are failed");
            else if( percent < 70 )
                Console.WriteLine("You are average");
            else
                Console.WriteLine("You are Awesome");
            Console.ReadKey();
        }
    }
}
