using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class FixedAccount:Account

    {
        private int createYear;
        public int CreateYear
        {
            get { return createYear; }
            set { createYear = value; }
        }
        private int tenureYear;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        public FixedAccount() { }
        public FixedAccount(string  name, string accNo, double balance, int createYear,int tenureYear ) : base(name, accNo, balance)
        {
            this.createYear = createYear;
            this.tenureYear = tenureYear;
        }
        public override void Withdraw(double amount)
        {
            int currentYr = DateTime.Now.Year;
            if(currentYr-createYear>=tenureYear)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Account is not matured enough");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Create Year: "+createYear);
            Console.WriteLine("Tenure Year: "+tenureYear);
            Console.WriteLine("Current Year: " + DateTime.Now);

        }
    }
}
