/**
414.
Given integer array nums, return the third maximum number in this array. If the third maximum does not exist, return the maximum number.
Example 1:

Input: nums = [3,2,1]
Output: 1
Explanation: The third maximum is 1.
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class ThirdMaximumNumber
    {
          public int ThirdMax(int[] nums) {
         nums = nums.OrderByDescending(n=>n).Distinct().ToArray();
            if (nums.Length < 3)
                return nums[0];

            return nums[2];
    }
    }
}
