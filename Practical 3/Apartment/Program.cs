using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment
{
    class Program
    {
        static void Main(string[] args)
        {
            Flat f1 = new OneBHK();
            f1.welcome();
            f1.display();
            f1.balcony();

            Flat f2 = new TwoBHK();
            f2.welcome();
            f2.display();
            f2.balcony();

            Flat f3 = new ThreeBHK();
            f3.welcome();
            f3.display();
            f3.balcony();

            Console.ReadKey();
        }
    }

    public class Flat
    {
        public void welcome()
        {
            Console.WriteLine("Welcome to Beautiful Apartment...");
        }
        public virtual void display()
        {
            Console.WriteLine("Not ready yet...");
        }
        public virtual void features()
        {
            Console.WriteLine("Not ready yet...");
            balcony();
        }
        public virtual void balcony()
        {
            Console.WriteLine("Not ready yet...");
        }
    }

    public class OneBHK : Flat
    {
        public override void display()
        {
            Console.WriteLine("This is 1 BHK flat");
        }
        public override void features()
        {
            Console.WriteLine("\tFeatures...");
            balcony();
        }
        public override void balcony()
        {
            Console.WriteLine("\tBalcony: Rectangular\n");
        }

    }


    public class TwoBHK : OneBHK
    {
        public override void display()
        {
            Console.WriteLine("This is 2 BHK flat");
        }
        public override void features()
        {
            Console.WriteLine("\tFeatures...");
            balcony();
        }
        public sealed override void balcony()
        {
            Console.WriteLine("\tBalcony: Circular\n");
        }
    }


    //Mark ThreeBHK class as sealed as no 4 or more BHK
    //are allowed in this apartment to build

    public sealed class ThreeBHK : TwoBHK
    {
        public override void display()
        {
            Console.WriteLine("This is 3 BHK flat");
        }
        public override void features()
        {
            Console.WriteLine("\tFeatures...");
            balcony();
        }
    }
}