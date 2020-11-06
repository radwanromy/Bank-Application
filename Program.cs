using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Information");
            Console.WriteLine();
            Console.WriteLine();

            Bank b = new Bank("Sonali Bank");
            Employee e1 = new Employee("Radwan", "0001",1000);
            Employee e2 = new Employee("Rahim", "123123",1000);
            Employee e3 = new Employee("Karim", "12322",1000);
            b.AddEmployee(e1,e2,e3);
            b.ShowAllEmployees();
            Console.WriteLine();
            Console.WriteLine("Customer and Account Information");
            Console.WriteLine();
            Console.WriteLine();
            Customer c = new Customer("121", "Radwan", "Rangpur");
            Account a1 = new SavingsAccount("Radwan", "12121", 10000);
            Account a2 = new FixedAccount("Radwan", "12121", 10000, 2015,5);
            //Employee a3 = new SalaryEmployee("Radwan", "12121", 10000, 1,10);
            c.AddAccounts(a1,a2);
            c.ShowAllAccounts();

        }
    }
}
