using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class Bank
    {
        // List to store customer objects
        private List<Customer> customers = new List<Customer>();
        public void AddCustomer(string customerName)
        {
            customers.Add(new Customer(customerName));
            Console.WriteLine($"Customer '{customerName}' added");
        }

        // Method to add an account for a specific customer
        public void AddAccount(string customerName, int accountNumber, decimal initialBalance)
        {
            Customer customer = customers.Find(c => c.Name == customerName);
            if (customer != null)
            {
                customer.AddAccount(accountNumber, initialBalance);
                Console.WriteLine($"Account {accountNumber} added to customer {customerName}");
            }
            else
            {
                Console.WriteLine($"Customer {customerName} not found");
            }
        }
        public void DisplayCustomerDetails()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Customer: {customer.Name}");
                foreach (Customer.Account account in customer.Accounts)
                {
                    Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}");
                }
            }
        }

        // Nested Customer class
        public class Customer
        {
            public string Name;
            public List<Account> Accounts;

            public Customer(string name)
            {
                Name = name;
                Accounts = new List<Account>();
            }
            public void AddAccount(int accountNumber, decimal initialBalance)
            {
                Accounts.Add(new Account(accountNumber, initialBalance));
            }

            // Nested Account class
            public class Account
            {
                public int AccountNumber;
                public decimal Balance;

                public Account(int accountNumber, decimal initialBalance)
                {
                    AccountNumber = accountNumber;
                    Balance = initialBalance;
                }
            }
        }
    }
}
