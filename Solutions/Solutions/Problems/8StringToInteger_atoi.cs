using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    class _8StringToInteger_atoi
    {
        internal void Solve()
        {
            //MyAtoi("0");
            //MyAtoi("2147483648");
            MyAtoi("-2147483649");
            //MyAtoi("+123");
            //MyAtoi("-123");
            //MyAtoi("+123.78");
            //MyAtoi("    123.78");
            //MyAtoi("abcd");
            //MyAtoi("+-123");
            //MyAtoi("abcd");
        }

        public int MyAtoi(string str)
        {
            int intValue = 0;
            int sign = 1;
            int i;

            //preprocess the string to get integers
            //skip spaces, next char should be +/- followed by digits, otherwise return 0.
            for ( i= 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                { continue; }
                else if (str[i] == '-')
                {
                    sign = -1;
                    ++i;
                    //Next char should be digit.
                    if (i < str.Length && str[i] - '0' >= 0 && str[i] - '0' <= 9)
                        break;
                    else return 0;
                }
                else if (str[i] == '+')
                {
                    ++i;
                    if (i < str.Length && str[i] - '0' >= 0 && str[i] - '0' <= 9)
                        break;
                    else return 0;
                }
                else if (str[i] - '0' >= 0 && str[i] - '0' <= 9)
                    break;
                else return 0;
            }

            for (;i<str.Length;i++)
            {
                if (str[i] - '0' >= 0 && str[i] - '0' <= 9)
                {
                    if (sign > 0)
                    {
                        if (intValue >= (int.MaxValue / 10) - (str[i] - '0'))
                            return int.MaxValue;
                        intValue = intValue * 10 + str[i] - '0';
                    }
                    else
                    {
                        if ((intValue) < ((int.MinValue) + (str[i] - '0')) / 10)
                            return int.MinValue;
                        intValue = intValue * 10 - (str[i] - '0');
                    }
                }
                //if not digit, return only the number processed till now.
                else
                    break;
            }
            return intValue;
        }

      
    }
}

