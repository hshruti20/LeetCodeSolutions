/**
977.
Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

 

Example 1:

Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].
Example 2:

Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class SquaresofaSortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            int first = 0;
            int last = nums.Length - 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(nums[first]) > Math.Abs(nums[last]))
                {
                    result[i] = nums[first] * nums[first];
                    first++;
                }
                else
                {
                    result[i] = nums[last] * nums[last];
                    last--;
                }
            }
            return result;

        }



        /*
      public int[] SortedSquares(int[] nums) {
      int[] arr = nums.Select(i=>Math.Abs(i)).ToArray();
      Array.Sort(arr);
      arr =arr.Select(i=>i*i).ToArray();
         return arr;
       }
        */





        /*
       public int[] SortedSquares(int[] nums) {
        
       for(int i=0;i<nums.Length;i++)
       {
         if(nums[i]<0)
         nums[i]=Math.Abs(nums[i]);
         nums[i]=nums[i]*nums[i];
       }
        Array.Sort(nums);
        return nums;
        
       }
         */
    }
}
