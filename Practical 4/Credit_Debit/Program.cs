using System;

namespace bank
{
    interface Icredit
    {
        void deposit();
    }

    interface Idebit
    {
        void withdraw();
    }

    class Account : Icredit, Idebit
    {
        public int balance = 0;

        public void deposit()
        {
            Console.WriteLine("\nEnter amount to deposit : ");
            balance += int.Parse(Console.ReadLine());
            Console.WriteLine("Deposite successful ");
            Console.WriteLine("New balance is : " + balance);
        }

        public void withdraw()
        {
            Console.WriteLine("\nEnter amount to withdraw : ");
            int amount = int.Parse(Console.ReadLine());

            if (amount > balance)
            {
                Console.WriteLine("Can not be withdraw ");
            }
            else
            {
                Console.WriteLine("withdraw successful ");
                balance -= amount;
                Console.WriteLine("New balance is : " + balance);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. deposit : ");
            Console.WriteLine("2. withdraw : ");
            Console.WriteLine("3. exit : ");
            Console.WriteLine("\nEnter your choice : ");
            int choice = int.Parse(Console.ReadLine());

            Account a = new Account();

            while (choice != 3)
            {
                if (choice == 1)
                {
                    a.deposit();
                }
                else if (choice == 2)
                {
                    a.withdraw();
                } 
                Console.WriteLine("1. deposit : ");
                Console.WriteLine("2. withdraw : ");
                Console.WriteLine("3. exit : ");
                Console.WriteLine("\nEnter your choice : ");
                choice = int.Parse(Console.ReadLine()); 
            }
            Console.Read();
        }
    }
}