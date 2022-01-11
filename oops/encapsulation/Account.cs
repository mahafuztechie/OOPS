using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.encapsulation
{
    class Account
    {
        private double balance;
        public void AddAmount(double amount)
            {
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine("Total balance is: " + balance);
            }
            else
            {
                Console.WriteLine("not a valid amount");
            }
            }
    }
}
