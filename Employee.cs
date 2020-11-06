using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Employee
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        /*protected double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }*/
        public Employee() { }
        public Employee(string name,string id, double balance)
        {
            this.name = name;
            this.id = id;
            //this.balance = balance;

        }
        /*virtual public void EmployeeSalaryAdd(double amount)
        {
            balance += amount;

        }
        public void EmployeeSalaryWithdraw(double amount)
        {
            if (amount < balance)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance To Withdraw Your Salary");
        }
        */
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
           // Console.WriteLine("Balance : " + balance);
        }
    }
}
