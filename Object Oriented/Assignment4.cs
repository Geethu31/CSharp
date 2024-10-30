using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    internal class BankAccount
    {
        public string AccountNumber;
        public string AccountHolderName;
        private decimal balance;
        public BankAccount(string accountNumber, string accountHolderName)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            balance = 0;
        }
        public BankAccount(string accountNumber, string accountHolderName, decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }
            balance = initialBalance;
        }
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance cannot be negative.");
                }
                else
                {
                    balance = value;
                }
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive");
            }
            else
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount} to account {AccountNumber}. New balance: {balance}");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds for this withdrawal");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdraw {amount} from account {AccountNumber}. New balance: {balance}");
            }
        }
    }
}
 