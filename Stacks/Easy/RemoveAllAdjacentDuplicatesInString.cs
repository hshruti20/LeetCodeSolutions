/**
1047.
You are given a string s consisting of lowercase English letters. A duplicate removal consists of choosing two adjacent and equal letters and removing them.

We repeatedly make duplicate removals on s until we no longer can.

Return the final string after all such duplicate removals have been made. It can be proven that the answer is unique.

 

Example 1:

Input: s = "abbaca"
Output: "ca"
Explanation: 
For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.  The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca".
Example 2:

Input: s = "azxxzy"
Output: "ay"
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class RemoveAllAdjacentDuplicatesInString
    {
        public string RemoveDuplicates(string s)
        {
            Stack<char> stk = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (stk.Count > 0)
                {
                    char c = stk.Peek();
                    if (c == s[i])
                    {
                        stk.Pop();
                    }
                    else
                        stk.Push(s[i]);
                }
                else
                    stk.Push(s[i]);
            }

            string a = string.Empty;
            foreach (var item in stk.Reverse())
            {
                a += item;
            }

            return a;

        }
    }
}
