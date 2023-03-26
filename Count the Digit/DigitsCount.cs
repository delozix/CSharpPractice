using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Count_the_Digit
{
    internal class DigitsCount
    {
        public static int CountTheDigits(int n, int d)
        {
            //Count the numbers of digits d used in the writing of all the k**2.
            //Implement the function taking n and d as parameters and returning this count.
            string str = "";
            for(var i = 0; i <= n; i++)
            {
                if (Math.Pow(i, 2).ToString().Contains(d.ToString()))
                {
                    str += Math.Pow(i, 2).ToString();
                }
            }
            return str.Count(c => c == Convert.ToChar(d.ToString()));
        }
    }
}
