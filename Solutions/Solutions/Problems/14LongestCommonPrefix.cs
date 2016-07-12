using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    class _14LongestCommonPrefix
    {
        internal void Solve()
        {
            string[] arrays = new string[] { "a", "b","aa" };
            LongestCommonPrefix(arrays);
        }
        public string LongestCommonPrefix(string[] strs)
        {
            int stringsCount = strs.Length;
            if (stringsCount == 1) return strs[0];
            int maxStringLength = int.MaxValue;
            foreach (var str in strs)
            {
                if (str.Length < maxStringLength)
                    maxStringLength = str.Length;
            }

            string returnString = "";
            int indx = 0;
            for (int i = 0; i < stringsCount - 1 && indx < maxStringLength; i++)
            {
                if (strs[i][indx] == strs[i + 1][indx])
                {
                    if (i + 2 == stringsCount)
                    {
                        returnString += strs[i][indx++];
                        i = -1;
                    }
                }
                else
                    break;
            }

            return returnString;
        }

    }
}
