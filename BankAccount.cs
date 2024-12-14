using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    internal class BankAccount
    {
        private double Balance;
        public string AccountHolder { get; set; }
        BankAccount(double balance, string accountHolder)
        {
            this.Balance = balance;
            this.AccountHolder = accountHolder;
        }
        public void Deposite(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("The amount must be positive");
                return;
            }
            Balance = Balance + amount;
            Console.WriteLine($"{amount} rupees deposited successfully");
        }
        public class Program
        {
            /*public static void Main(string[] args)
            {
                BankAccount account = new BankAccount(5000, "Pooja");

                Console.WriteLine($"Account Holder: {account.AccountHolder}, Balance: {account.Balance:C}");

                // Deposit money (indirectly updates balance)
                account.Deposite(200);
            }*/

        }
    }
}