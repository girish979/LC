using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class _2AddTwoNumbers
    {
        public ListNode AddTwoNumbers_Solution2(ListNode l1, ListNode l2)
        {
            
            ListNode dummyHead = new ListNode(0);
            ListNode Current = dummyHead;
            int carry = 0;
            while(l1!=null || l2 != null)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;
                int sum = x + y + carry;

                carry = sum / 10;
                Current.next = new ListNode(sum % 10);
                Current = Current.next;
                if(l1!= null)l1 = l1.next;
                if(l2!=null) l2 = l2.next;
            }
            if (carry != 0)
                Current.next = new ListNode(carry);
            return dummyHead.next;
        }
    }
}
