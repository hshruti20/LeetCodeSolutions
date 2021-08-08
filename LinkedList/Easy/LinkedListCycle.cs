/**
141.
Given head, the head of a linked list, determine if the linked list has a cycle in it.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.

Return true if there is a cycle in the linked list. Otherwise, return false.

Example 1:
Input: head = [1,2], pos = 0
Output: true
Explanation: There is a cycle in the linked list, where the tail connects to the 0th node.
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class LinkedListCycle
    {
           if (head == null)
           return false;
        ListNode slow = head;
        ListNode fast = slow.next;
        while(slow!=null && fast!=null && fast.next!=null)
        {
            if(slow==fast)
            return true;
                    
            slow =slow.next;
            fast=fast.next.next;
        }
         return false;
    }
    
}
