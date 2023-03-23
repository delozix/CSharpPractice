using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNameGenerator
{
    internal class BandNameGenerator
    {
        public static string BandNameGen(string str)
        {
            //However, when a noun STARTS and ENDS with the same letter,
            //she likes to repeat the noun twice and connect them together with the first and last letter,
            //combined into one word (WITHOUT "The" in front).
            char[] str1 = str.ToCharArray();
            if (str1[0] != str1[str1.Length - 1])
            {
                return "The " + str1[0].ToString().ToUpper() + str.Remove(0, 1);
            }
            else
            {
                return str1[0].ToString().ToUpper() + str.Remove(0, 1) + str.Remove(0, 1);
            }
            return "not working";
        }
    }
}
