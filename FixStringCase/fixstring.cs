using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixStringCase
{
    internal class fixstring
    {
        public static string FixStringCase(string s)
        {
            int lower = 0;
            int upper = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == char.ToLower(s[i]))
                {
                    lower++;
                }
                else { upper++; }
            }
            return lower > upper || lower == upper ? s.ToLower() : s.ToUpper();
        }
    }
}
