/**
232.
Implement a first in first out (FIFO) queue using only two stacks. The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).

Implement the MyQueue class:

void push(int x) Pushes element x to the back of the queue.
int pop() Removes the element from the front of the queue and returns it.
int peek() Returns the element at the front of the queue.
boolean empty() Returns true if the queue is empty, false otherwise.
Notes:

You must use only standard operations of a stack, which means only push to top, peek/pop from top, size, and is empty operations are valid.
Depending on your language, the stack may not be supported natively. You may simulate a stack using a list or deque (double-ended queue) as long as you use only a stack's standard operations.
Follow-up: Can you implement the queue such that each operation is amortized O(1) time complexity? In other words, performing n operations will take overall O(n) time even if one of those operations may take longer.

 

Example 1:

Input
["MyQueue", "push", "push", "peek", "pop", "empty"]
[[], [1], [2], [], [], []]
Output
[null, null, null, 1, 1, false]

Explanation
MyQueue myQueue = new MyQueue();
myQueue.push(1); // queue is: [1]
myQueue.push(2); // queue is: [1, 2] (leftmost is front of the queue)
myQueue.peek(); // return 1
myQueue.pop(); // return 1, queue is [2]
myQueue.empty(); // return false
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class ImplementQueueusingStacks
    {
        Stack<int> stk;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            stk = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            int[] temp = stk.ToArray();
            stk.Clear();
            stk.Push(x);
            for (int i = temp.Length - 1; i >= 0; i--)
                stk.Push(temp[i]);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            return stk.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            return stk.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return stk.Count > 0 ? false : true;
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
}
