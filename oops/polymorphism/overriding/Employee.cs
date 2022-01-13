using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.polymorphism.overriding
{
    class Employee : Bank 
    {
       
        public void EmpBalance()
        {
            balance = balance + empSalary;
            Console.WriteLine("hello "+ empName+ "your number is " +empPhone);
            Console.WriteLine(" and your balance is : " + balance);
            
        }
        public override void Savings()
        {
            Console.WriteLine("hey " + empName + "you created a savings account");

        }
            

    }
}
