/**
560.
Given an array of integers nums and an integer k, return the total number of continuous subarrays whose sum equals to k.

 

Example 1:

Input: nums = [1,1,1], k = 2
Output: 2
Example 2:

Input: nums = [1,2,3], k = 3
Output: 2
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class SubarraySumEqualsK
    {
        public class Solution
        {
            public int SubarraySum(int[] nums, int k)
            {
                int count = 0;
                int sum = 0;
                Dictionary<int, int> dict = new Dictionary<int, int>() { { 0, 1 } };
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];


                    if (dict.ContainsKey(sum - k))
                    {
                        count += dict[sum - k];
                    }

                    if (!dict.ContainsKey(sum))
                        dict.Add(sum, 1);
                    else
                        dict[sum]++;
                }

                return count;
            }
        }

        /*
        public class Solution
        {
            public int SubarraySum(int[] nums, int k)
            {
                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    int sum = 0;
                    for (int j = i; j < nums.Length; j++)
                    {
                        sum += nums[j];
                        if (sum == k)
                            count++;
                    }
                }
                return count;

            }
        }
        */
    }
}
