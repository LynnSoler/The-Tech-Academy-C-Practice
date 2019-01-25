using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Instantiate_p114
{
    class Integer_Methods //CLASS CREATION
    {
        public int methodOne(int num) //INT TO RETURN INT
        {
            int result = num + 12; //PASS INT
            return result;
        }

        public int methodOne(decimal num) //DECIMAL TO RETURN INT
        {
            int result = Convert.ToInt32(num) + 85; //PASS INT
            return result;
        }

        public int methodOne(string num) //STRING TO RET INT
        {
            int result = Convert.ToInt32(num) + 17; //PASS INT
            return result;
        }
    }
}
