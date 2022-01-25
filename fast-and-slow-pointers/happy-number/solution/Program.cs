using System;

namespace solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.IsHappy(116);
        }
    }

    public class Solution
    {
        public bool IsHappy(int n)
        {
            int slow = n;
            int fast = Next(n);

            while(slow != fast && fast != 1)
            {
                slow = Next(slow);
                fast = Next(Next(fast));
            }

            return fast == 1;
        }

        private int Next(int n)
        {
            int totalSum = 0;
            while(n != 0)
            {
                int digit = n % 10;
                n = n / 10;
                totalSum += digit * digit;
            }

            return totalSum;
        }
    }
}
