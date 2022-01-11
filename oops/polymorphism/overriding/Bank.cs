using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.polymorphism.overriding
{
    internal class Bank
    {
        public void Savings()
        {
            Console.WriteLine(" creating savings account");
        }
        public void Current()
        {
            Console.WriteLine(" creating current account");
        }
    }
}
