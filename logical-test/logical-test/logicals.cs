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
            if (pStrText.Length%2 == 0)
            {
                for (int intLoop = pStrText.Length - 1; intLoop >= intEnd; intLoop--)
                {
                    str2 += pStrText[intLoop];
                }
            }
            else
            {
                for (int intLoop = pStrText.Length - 1; intLoop > intEnd; intLoop--)
                {
                    str2 += pStrText[intLoop];
                }
            }            
            _ = str2.ToLower();

            if (str1 == str2) { return true; } else { return false; }
        }

        public void Stars (int pIntNumber)
        {
            string strStars = string.Empty;
            for (int i = 0; i < pIntNumber; i++)
            {                
                for (int j = 0; j <= i; j++)
                {
                    strStars += "*"; 
                }
                Console.WriteLine(strStars); strStars = "";
            }
        }

        public enum Type { SAMA_KAKI, SAMA_SISI, IRREGULAR, BUKAN_SEGITIGA }
        public Type TriangleType (int a, int b, int c)
        {
            if (a == 0 || b == 0 || c == 0) { return Type.BUKAN_SEGITIGA; }
            else if (a == b && b == c) { return Type.SAMA_SISI; }
            else if (a == b || a == c || b == c) { return Type.SAMA_KAKI; }
            else if (a != b && b != c) { return Type.IRREGULAR; }
            else { return Type.BUKAN_SEGITIGA;}
        }
    } 
}
