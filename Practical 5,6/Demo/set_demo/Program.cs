using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_demo
{
    class Accounts
    {
        float init_amount;
        static float interest;
        public float InitialAmount
        {
            set
            {
                if(value<1000)
                {
                    Console.WriteLine("Initial amount cannot be less than 1000");
                    return;
                }
                init_amount = value;
            }

            get
            {
                return init_amount;
            }
        }
        public static float InterestRate
        {
            get
            {
                return interest;
            }
        }
        public Accounts()
        {
            this.InitialAmount = 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Accounts a1 = new Accounts();
            Console.WriteLine(Accounts.InterestRate);
            Console.WriteLine(a1.InitialAmount);
            Console.ReadKey();
        }
    }
}
