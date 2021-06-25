/**
20.
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
 

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
Example 4:

Input: s = "([)]"
Output: false
Example 5:

Input: s = "{[]}"
Output: true
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var k = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(')
                {
                    k.Push(')');
                    continue;
                }
                else if (c == '{')
                {
                    k.Push('}');
                    continue;
                }
                else if (c == '[')
                {
                    k.Push(']');
                    continue;
                }
                else if (k.Count == 0 || c != k.Pop())
                    return false;
            }

            return k.Count == 0;

        }
    }
}
