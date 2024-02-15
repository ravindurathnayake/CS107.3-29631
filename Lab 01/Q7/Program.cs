using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;

            while (true)
            {
                Console.WriteLine("\n \n Hello, Welcome to the ATM machine!\n");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit\n");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Your current balance is: " + balance);
                        break;

                    case 2:
                        Console.Write("Enter the amount you want to deposit: ");
                        double deposit = Convert.ToDouble(Console.ReadLine());
                        balance += deposit;
                        Console.Write("Deposit successful. Your new balance is: " + balance);
                        break;

                    case 3:
                        Console.Write("Enter the amount you want to withdraw: ");
                        double withdraw = Convert.ToDouble(Console.ReadLine());
                        if (withdraw > balance)
                        {
                            Console.WriteLine("Insufficient funds. Withdrawal failed\n.");
                        }
                        else
                        {
                            balance -= withdraw;
                            Console.Write("Withdrawal successful. Your new balance is: " + balance);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Thank you for using the ATM machine. Goodbye!\n");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }
            }
        }
    }
}