using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject1
{

    public class BankAccount
    {
        private double balance;
        public void Deposit(double amount)
        {
            if (amount > 0)

                balance += amount;

        }
        public void Withdraw(double amount)
        {
            if (balance > amount)
                balance -= amount;
            else
                Console.WriteLine("Insufficient balance");
        }
        public double getbalance()
        {
            return balance;
        }
    }

         public class Program
       {
        public static void Main()
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            account.Withdraw(500);
            Console.WriteLine("Current balance is  " + account.getbalance());
        }
    }

}



