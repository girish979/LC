using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    class _344ReverseString
    {
        internal void Solve()
        {
            ReverseString("hello");
        }

        public string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
