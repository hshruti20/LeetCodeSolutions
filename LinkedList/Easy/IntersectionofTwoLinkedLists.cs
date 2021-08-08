/**
160.
Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect. If the two linked lists have no intersection at all, return null.

Example 1:
Input: intersectVal = 8, listA = [4,1,8,4,5], listB = [5,6,1,8,4,5], skipA = 2, skipB = 3
Output: Intersected at '8'
Explanation: The intersected node's value is 8 (note that this must not be 0 if the two lists intersect).
From the head of A, it reads as [4,1,8,4,5]. From the head of B, it reads as [5,6,1,8,4,5]. There are 2 nodes before the intersected node in A; There are 3 nodes before the intersected node in B.
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class IntersectionofTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var p1 = headA;
            var p2 = headB;

            if (p1 == null || p2 == null) return null;

            while (p1 != null && p2 != null && p1 != p2)
            {
                p1 = p1.next;
                p2 = p2.next;

                if (p1 == p2) return p1;

                if (p1 == null) p1 = headB;
                if (p2 == null) p2 = headA;
            }

            return p1;
        }
    }

}
