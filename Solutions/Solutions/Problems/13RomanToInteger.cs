using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    class _13RomanToInteger
    {
        internal void Solve()
        {
            //V 5
            //X 10
            //L 50
            //C 100
            //D 500
            //M 1000

            //RomanToInt("II");
            //RomanToInt("VI");
            //RomanToInt("IV");
            RomanToInt("LXXXIX");

        }
        int getValueOf(char ch)
        {
            int Value = 0;
            switch (ch)
            {
                case 'I':
                    Value = 1;
                    break;
                case 'V':
                    Value = 5;
                    break;
                case 'X':
                    Value = 10;
                    break;
                case 'L':
                    Value = 50;
                    break;
                case 'C':
                    Value = 100;
                    break;
                case 'D':
                    Value = 500;
                    break;
                case 'M':
                    Value = 1000;
                    break;
                default:
                    Value = -1;
                    break;
            }
            return Value;
        }

        public int RomanToInt(string s)
        {
            int intValue = 0;
            int prevChartoIntValue = 4000;
            for (int i = 0; i < s.Length; i++)
            {
                int chartoInt = getValueOf(s[i]);
                if (prevChartoIntValue < chartoInt)
                {
                    intValue -= 2 * prevChartoIntValue;
                }
                intValue = chartoInt + intValue;
                prevChartoIntValue = chartoInt;
            }


            return intValue;
        }
    }
}
