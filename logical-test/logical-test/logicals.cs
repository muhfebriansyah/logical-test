using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_test
{
    internal class logicals
    {
        public bool IsPalindrome(string pStrText)
        {
            int intEnd = pStrText.Length/2;

            //string 1
            string str1 = string.Empty;
            for (int intLoop=0; intLoop<intEnd; intLoop++)
            {
                str1 += pStrText[intLoop];
            }
            _ = str1.ToLower();

            //string 2
            string str2 = string.Empty;
            for (int intLoop = pStrText.Length-1; intLoop > intEnd; intLoop--)
            {
                str2 += pStrText[intLoop];
            }
            _ = str2.ToLower();

            if (str1 == str2) { return true; } else { return false; }
        }
    }
}
