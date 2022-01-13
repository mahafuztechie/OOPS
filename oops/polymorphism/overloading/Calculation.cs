using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.polymorphism.overloading
{
    public class Calculation
    {
        public int a;
        public int b;
        public int c;
        public double e;
        public int Add()
        {
            Console.WriteLine("enter a number to add");
            int a =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number to add");
            int b = Convert.ToInt32(Console.ReadLine());
            return  c = a + b;
        }
       

        public double Add(float x, double y)
        {
            Console.WriteLine("enter a number to add");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number to add");
            int b = Convert.ToInt32(Console.ReadLine());
            Double d = x + y;
            return e = a + b + d;
        }
        public int Add(int x, int y, int z)
        {
            Console.WriteLine("enter a number to add");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number to add");
            int b = Convert.ToInt32(Console.ReadLine());
            return c = a + b + x + y + z;
        }
    }
}
