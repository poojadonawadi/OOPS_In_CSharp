using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    internal class BankAccount
    {
        private double balance;
        public string accountHolder { get; set; }
        public BankAccount(double balance, string accountHolder)
        {
            this.balance = balance;
            this.accountHolder = accountHolder;
        }
        public void Deposite(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("The amount must be positive");
                return;
            }
            balance = balance + amount;
            Console.WriteLine($"{amount} rupees deposited successfully");
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}