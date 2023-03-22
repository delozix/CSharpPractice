using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    internal class DivCon
    {
        public static int DivConq(Object[] objArray)
        {
            object str = "str";
            object num = 1;
            int strResult = 0;
            int numResult = 0;
            for (int i = 0; i < objArray.Length; i++)
            {
                if (objArray[i].GetType() == str.GetType())
                {
                    strResult += Convert.ToInt32(objArray[i]);
                }
                else { numResult += Convert.ToInt32(objArray[i]); }
            }
            return (numResult - strResult);
        }
    }
}
