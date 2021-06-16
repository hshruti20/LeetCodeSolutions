/**
1021.
A valid parentheses string is either empty (""), "(" + A + ")", or A + B, where A and B are valid parentheses strings, and + represents string concatenation.  For example, "", "()", "(())()", and "(()(()))" are all valid parentheses strings.

A valid parentheses string s is primitive if it is nonempty, and there does not exist a way to split it into s = A+B, with A and B nonempty valid parentheses strings.

Given a valid parentheses string s, consider its primitive decomposition: s = P_1 + P_2 + ... + P_k, where P_i are primitive valid parentheses strings.

Return s after removing the outermost parentheses of every primitive string in the primitive decomposition of S.

 

Example 1:

Input: s = "(()())(())"
Output: "()()()"
Explanation: 
The input string is "(()())(())", with primitive decomposition "(()())" + "(())".
After removing outer parentheses of each part, this is "()()" + "()" = "()()()".
Example 2:

Input: s = "(()())(())(()(()))"
Output: "()()()()(())"
Explanation: 
The input string is "(()())(())(()(()))", with primitive decomposition "(()())" + "(())" + "(()(()))".
After removing outer parentheses of each part, this is "()()" + "()" + "()(())" = "()()()()(())".
Example 3:

Input: s = "()()"
Output: ""
Explanation: 
The input string is "()()", with primitive decomposition "()" + "()".
After removing outer parentheses of each part, this is "" + "" = "".
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class RemoveOutermostParentheses
    {
        public string RemoveOuterParentheses(string s)
        {
            Stack<char> stk = new Stack<char>();
            StringBuilder sb = new StringBuilder();

            foreach (var c in s)
            {
                if (stk.Count == 0)
                    stk.Push(c);
                else
                {
                    if (c == '(')
                    {
                        stk.Push(c);
                        sb.Append(c);
                    }
                    else
                    {
                        if (stk.Count > 1)
                            sb.Append(c);
                        stk.Pop();
                    }
                }

            }
            return sb.ToString();
        }
    }
}
