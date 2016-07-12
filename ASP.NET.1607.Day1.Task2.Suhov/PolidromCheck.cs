using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day1.Task2.Suhov
{
    public static class PolidromCheck
    {
        /// <summary>Checking whether number is polidrom</summary> 
        /// <param name="value">Number which should be checked</param> 
        /// <returns>If the number <paramref name="n"/> is polidrom, result:(<paramref name="value"/>) will be true</returns> 
        public static bool IsPolidrom(int numb)
        {
            string str = Math.Abs(numb).ToString();
            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int ii = str.Length - 1-i; ii > 0; ii--)
                {
                    if (str[i] != str[ii])
                        return false;
                    else
                        break;
                }
            }
            return true;
        }
    }
}
