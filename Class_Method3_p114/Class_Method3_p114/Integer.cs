using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method3_p114
{
    class Integer //CREATE CLASS
    {
        public int MathOperation(int val)
        {
            return (100 - val);
        }

        public decimal MathOperation(decimal val)
        {
            return (10 * val);
        }

        public int MathOperation(string val)
        {
            int valThree = Convert.ToInt32(val);
            return valThree;
        }
    }
}
