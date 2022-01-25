using System;
using System.Collections.Generic;

namespace solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });
            //solution.FindDisappearedNumbers(new int[] { 1,1 });
        }
    }

    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> result = new List<int>();


            int i = 0;

            while(i < nums.Length)
            {
                int temp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = temp;

                if (nums[nums[i] - 1] == nums[i])
                    i++;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != j + 1)
                    result.Add(j+1);
            }

            return result;
        }
    }
}
