using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEndsWith
{
    internal class StringStartsWith
    {
        public static bool Solution(string str, string ending)
        {
            if (str.Length < ending.Length)
            {
                return false;
            }
            return str.Substring(str.Length - ending.Length) == ending;
        }
    }
}
