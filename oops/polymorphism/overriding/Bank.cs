using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.polymorphism.overriding
{
    internal class Bank
    {
         public string empName;
        public int empPhone;
        public int empSalary;
        public int balance;
        public virtual void Savings()
        {
            Console.WriteLine(" creating savings account");
        }
        public void Current()
        {
            Console.WriteLine(" creating current account");
        }
    }
}
