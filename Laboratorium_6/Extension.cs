using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_6
{
    static class Extension
    {
        public static string jumpingLetters(this string str)
        {
            int symbolNumber = 0;
            string result = "";
            foreach (var symbol in str)
            {
                symbolNumber++;
                if (symbolNumber % 2 == 1)
                {
                    result += char.ToUpper(symbol);
                }
                else
                {
                    result += char.ToLower(symbol);
                }
            }
            return result;
        }

        public static char toLower(this char ch)
        {
            if (char.IsLetter(ch))
            {
                return char.ToLower(ch);
            }
            else
            {
                return ch;
            }
        }
    }
}
