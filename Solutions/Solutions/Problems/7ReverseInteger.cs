using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    class _7ReverseInteger
    {
        internal void Solve()
        {
            Reverse(1534236469);
        }

        public int Reverse(int x)
        {
            int sign = 1;
            if (x < 0)
            {
                x *= -1;
                sign = -1;
            }
            int temp = 0;
            while(x >0)
            {
                if (temp > int.MaxValue / 10)
                    return 0;
                temp = temp *10 + x%10;
                x /= 10;
            }
            return temp*sign;
        }
    }
}
