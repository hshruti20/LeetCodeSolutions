/**
155.
Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

Implement the MinStack class:

MinStack() initializes the stack object.
void push(val) pushes the element val onto the stack.
void pop() removes the element on the top of the stack.
int top() gets the top element of the stack.
int getMin() retrieves the minimum element in the stack.
 

Example 1:

Input
["MinStack","push","push","push","getMin","pop","top","getMin"]
[[],[-2],[0],[-3],[],[],[],[]]

Output
[null,null,null,null,-3,null,0,-2]

Explanation
MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin(); // return -3
minStack.pop();
minStack.top();    // return 0
minStack.getMin(); // return -2
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class MinStack
    {
        /** initialize your data structure here. */
        private readonly Stack<(int Value, int Min)> stk;
        public MinStack()
        {
            stk = new Stack<(int, int)>();
        }

        public void Push(int val)
        {
            var min = stk.Any() ? Math.Min(val, GetMin()) : val;
            stk.Push((val, min));
        }

        public void Pop()
        {
            stk.Pop();
        }

        public int Top()
        {
            return stk.Peek().Value;
        }

        public int GetMin()
        {
            return stk.Peek().Min;
        }
    }
}
