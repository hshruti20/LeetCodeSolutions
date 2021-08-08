/**
21.
Merge two sorted linked lists and return it as a sorted list. The list should be made by splicing together the nodes of the first two lists.

Example 1:
Input: l1 = [1,2,4], l2 = [1,3,4]
Output: [1,1,2,3,4,4]

Example 2:

Input: l1 = [], l2 = []
Output: []
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            ListNode d = new ListNode();
            var cur = d;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                cur = cur.next;
            }
            if (l1 != null)
                cur.next = l1;
            if (l2 != null)
                cur.next = l2;

            return d.next;

        }
    }

}
