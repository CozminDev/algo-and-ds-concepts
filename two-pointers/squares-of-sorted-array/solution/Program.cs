using System;
using System.Collections.Generic;

namespace solution
{
   class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            sol.SortedSquares(new int[] { -5, -3, -2, -1 });
        }
    }

    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            List<int> result = new List<int>();

            int i = 0;
            int j = nums.Length - 1;

            while(i <= j)
            {
                int num1 = nums[i] * nums[i];
                int num2 = nums[j] * nums[j];

                if(num2 > num1)
                {
                    result.Add(num2);
                    j--;
                }
                else
                {
                    result.Add(num1);
                    i++;
                }
            }

            result.Reverse();

            return result.ToArray();
        }
    }
}
