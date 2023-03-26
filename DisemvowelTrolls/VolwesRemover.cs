using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisemvowelTrolls
{
    internal class VolwesRemover
    {
        public static string VolwesRemove(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                bool isVowel = "aeiouAEIOU".IndexOf(str[i]) >= 0;
                if (isVowel == false)
                {
                    result += str[i];
                }
            }
            return result;
        }
    }
}
