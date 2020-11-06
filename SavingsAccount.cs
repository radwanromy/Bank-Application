using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class SavingsAccount:Account
    {
        public SavingsAccount() { }
        public SavingsAccount(string name,string accNo, double balance) : base(name,accNo,balance)
        {

        }
        public override void Withdraw(double amount)
        {
            if(balance-amount>=500)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance");
        }

    }
}
