using System;

namespace solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            sol.solve(new int[] { 2, 0, 2, 1, 1, 0 });
        }
    }

    class Solution
    {
        public void solve(int[] nums)
        {
            int red = 0;
            int white = 0;
            int blue = 0;

            foreach (int num in nums)
            {
                if (num == 0)
                    red++;
                else if (num == 1)
                    white++;
                else
                    blue++;
            }

            addColors(0, 0, red, nums);
            addColors(1, red, red + white, nums);
            addColors(2, red + white, red + white + blue, nums);
        }

        private void addColors(int color, int start, int end, int[] nums)
        {
            for(int i = start; i < end; i++)
            {
                nums[i] = color;
            }
        }
    }
}
