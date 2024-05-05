using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();
            myAccount.AccountNumber = "123456";
            myAccount.Balance = 10000;

            double depositAmount = 555;
            myAccount.Deposit(depositAmount);

            Console.WriteLine("Deposit of Rs." + depositAmount + " successful.");
            Console.WriteLine("Updated Balance: Rs." + myAccount.Balance);

            Console.ReadKey();
        }
    }
}