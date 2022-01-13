using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.passbyvalueandref.pass_by_value
{
     class PassByValue
    {
        public string name;
        
        public void PassValue(int a)
        {
             a = 200;
            Console.WriteLine(a);
        }
    }
}
