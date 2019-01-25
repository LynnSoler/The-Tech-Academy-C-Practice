using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_p111
{
    class Integer //CLASS FILE
    {
        public int firstNum = 50;
        public void Add(int val)
        {
            Console.WriteLine(firstNum + val);
        }

        public void Subtract (int val)
        {
            Console.WriteLine(firstNum - val);
        }

        public void Multiply (int val)
        {
            Console.WriteLine(firstNum * val);
        }
    }
}
