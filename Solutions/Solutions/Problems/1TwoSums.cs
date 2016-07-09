using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    class _1TwoSums
    {
        public void TwoSums()
        {

        }

        public int[] Solution1(int[] nums, int target)
        {
            int[] returnValues = new int[2];
            Dictionary<int, int> hashTable = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                hashTable.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int search = target - nums[i];
                if(hashTable.ContainsKey(search) && hashTable[search]!= i)
                {
                    returnValues[0] = i;
                    returnValues[1] = hashTable[search] ;
                    break;
                }
            }

            return returnValues;
        }
    }
}
