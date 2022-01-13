using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.Abstraction
{
    abstract class Shape
    {
        public abstract void DrawShape();
        public void ReadMe()
        {
            Console.WriteLine("implement my abstract methods");
        }
    }
}
