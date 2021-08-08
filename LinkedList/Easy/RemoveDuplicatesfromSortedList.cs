/**
83.
Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.

Example 1:
Input: head = [1,1,2]
Output: [1,2]
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class RemoveDuplicatesfromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode node1 = head, node2 = head.next;

            while (node2 != null)
                if (node1.val == node2.val)
                {
                    node1.next = node2.next;
                    node2.next = null;
                    node2 = node1.next;
                }
                else
                {
                    node1 = node2;
                    node2 = node2.next;
                }
            return head;
        }
    }

}
