using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    class _9PalindromeNumber
    {
        internal void Solve()
        {
            bool value = IsPalindrome(1000021);
            //IsPalindrome(-123);
            //IsPalindrome(0);
        }
        /// <summary>
        ///     compare last and first digits.
        ///     
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome(int x)
        {
            if( x < 0 ) return false;
            if (x == 0) return true;

            int numberLenght = 1;

            while (x/numberLenght >= 10)
                numberLenght *= 10;

            while(x != 0)
            {
                int first = x / numberLenght;
                int last = x % 10;
                if (first != last) return false;

                x = (x % numberLenght) / 10;
                numberLenght /= 100;
            }

            return true;
        }
    }
}
