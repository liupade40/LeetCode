using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = new ListNode(0);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(3);
            var l2 = new ListNode(0);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);
            new Solution().AddTwoNumbers(l1, l2);//zheci tianjia de 
            Console.ReadKey();
        }

    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var q = l1;
            var p = l2;
            var head = new ListNode(0);
            var current = head;
            var carry = 0;
            current.next = new ListNode(1);
            while (q != null || p != null)
            {
                var x = q != null ? q.val : 0;
                var y = p != null ? p.val : 0;
                var sum = x + y + carry;
                current.next = new ListNode(sum % 10);
                current = current.next;
                carry = sum / 10;
                if (q != null) q = q.next;
                if (p != null) p = p.next;
            }

            if (carry != 0) current.next = new ListNode(carry);
            return head.next;
        }
    }
}
