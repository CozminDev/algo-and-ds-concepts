using System.Collections.Generic;

namespace solution
{
    //temp = nums[i];
    //nums[i] = thing;
    //thing = temp;
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //solution.FindDuplicates(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });
            solution.FindDuplicates(new int[] { 1, 1, 2 });
        }
    }

    public class Solution
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            IList<int> results = new List<int>();

            int i = 0;
            while(i < nums.Length)
            {
                int num = nums[i];
                int temp = num;

                nums[i] = nums[num - 1];
                nums[num - 1] = temp;

                if (nums[nums[i] - 1] == nums[i])
                {
                    if (i != nums[i] - 1 && !results.Contains(nums[i]))
                        results.Add(nums[i]);

                    i++;
                }
                   
            }

            return results;
        }
    }
}
