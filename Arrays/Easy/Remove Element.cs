/**
27.
Given an array nums and a value val, remove all instances of that value in-place and return the new length.

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

The order of elements can be changed. It doesn't matter what you leave beyond the new length.
Example 1:

Input: nums = [3,2,2,3], val = 3
Output: 2, nums = [2,2]
Explanation: Your function should return length = 2, with the first two elements of nums being 2.
It doesn't matter what you leave beyond the returned length. For example if you return 2 with nums = [2,2,3,3] or nums = [2,2,0,0], your answer will be accepted.
Example 2:

Input: nums = [0,1,2,2,3,0,4,2], val = 2
Output: 5, nums = [0,1,4,0,3]
Explanation: Your function should return length = 5, with the first five elements of nums containing 0, 1, 3, 0, and 4. Note that the order of those five elements can be arbitrary. It doesn't matter what values are set beyond the returned length.
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
            int i = 0, j = 0, result = 0;
            while (i < nums.Length && j < nums.Length)
            {
                if (nums[j] == val)
                {
                    j++;

                }
                else
                {
                    nums[i] = nums[j];
                    i++;
                    j++;
                    result++;
                }
            }
            return result;
        }

        /*
        public int RemoveElement(int[] nums, int val)
        {

            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            Array.Resize(ref nums, j);
            return nums.Length;

        }
        */
    }

