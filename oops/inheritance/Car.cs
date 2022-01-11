using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.inheritance
{
    class Car : Vehicle
    {
        public string carName;
        public void Stop()
        {
            Console.WriteLine("car is  stopped");
        }
    }
}
