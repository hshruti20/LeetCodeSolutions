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
    class RotateArray
    {
        public class Solution
        {

            public void Rotate(int[] nums, int k)
            {
                int n = nums.Length;
                k = k % n;
                Array.Reverse(nums, 0, n);
                Array.Reverse(nums, 0, k);
                Array.Reverse(nums, k, n - k);



            }

        }

        /*
        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            int[] output = new int[n];
            for (int i = 0; i < n; i++)
            {
                output[(i + k) % n] = nums[i];
            }
            for (int j = 0; j < n; j++)
            {
                nums[j] = output[j];
            }

        }
        */


        /*
         //Time Limit Exceeded
        public void Rotate(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0)
            {
                return;
            }
            int n = nums.Length;
            int last = 0;
            int temp = 0;
            int current = 0;
            for (int i = 0; i < k; i++)
            {
                last = nums[n - 1];
                temp = last;
                for (int j = 0; j < n; j++)
                {
                    current = nums[j];
                    nums[j] = temp;
                    temp = current;

                }
            }

        }
        */


    }
}
