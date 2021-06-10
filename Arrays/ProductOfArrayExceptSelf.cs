/**
238.
Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.

 

Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class ProductOfArrayExceptSelf
    {
        public class Solution
        {

            public int[] ProductExceptSelf(int[] nums)
            {
                if (nums == null || nums.Length < 2)
                    return nums;

                int[] result = new int[nums.Length];

                int left = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    result[i] = left;
                    left *= nums[i];
                }

                int right = 1;
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    result[i] *= right;
                    right *= nums[i];
                }

                return result;
            }

        }

    }
}
