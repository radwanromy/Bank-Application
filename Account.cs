using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Account
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string accNo;

        public string AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }
        protected double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account() { }
        public Account(string name,string accNo, double balance)
        {
            this.name = name;
            this.accNo = accNo;
            this.balance = balance;

        }
        public void Deposit(double amount)
        {
            balance += amount;

        }
        virtual public void Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance");
        }
        virtual public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Account Number: " + accNo);
            Console.WriteLine("Balance : " + balance);
        }
        
    }
}
