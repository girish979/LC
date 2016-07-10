using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    class _3LongestSubstringWithoutRepeatingCharacters
    {
        public void Solve()
        {
            LengthOfLongestSubstring("au");
            //Solution2("abcabcbb");
        }

        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;

            int[] visited = Enumerable.Repeat<int>(-1, 128).ToArray<int>();
            int currentMax = 1, Max = 1;
            visited[s[0]] = 0;
            for(int i=1; i<s.Length; i++)
            {
                int previousIndex = visited[s[i]];

                if (previousIndex == -1 || i - previousIndex > currentMax)
                    currentMax++;
                else
                {
                    if (Max < currentMax)
                        Max = currentMax;
                    currentMax = i - previousIndex;
                }    
                visited[s[i]] = i;
            }
            if (Max < currentMax)
                Max = currentMax;

            return Max;
        }

        //Not working
        public int Solution2(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int n = s.Length, ans = 0;
            for (int j = 0, i = 0; j < n; j++)
            {
                if (dic.ContainsKey(s[j]))
                {
                    int val;
                    dic.TryGetValue(s[j], out val);
                    i = Math.Max(val, i);
                }
                else
                    dic[s[j]] = j + 1;
                    //dic.Add(s[j], j + 1);
                ans = Math.Max(ans, j - i + 1);
                
            }
            return ans;
        }
    }
}
