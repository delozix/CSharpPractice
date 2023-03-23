using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleOf3Or5
{
    internal class MultipleOfTwoNums
    {
        //Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
        //Additionally, if the number is negative, return 0 (for languages that do have them).
        public static int MultipleOf3or5(int value)
        {
            int result = 0;
            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
