using System;

namespace solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            sol.FindKthPositive(new int[] { 2, 3, 4, 7, 11 }, 5);
        }


    }

    public class Solution
    {
        //keep 2 indexes i,j
        //if i == arr[j] increment i and j
        //if i != arr[j] increment i and decrement k
        //do this while k >= 0
        //return i
        public int FindKthPositive(int[] arr, int k)
        {
            int j = 0;
            int i = 1;

            while(k > 0)
            {
                if(j < arr.Length && i == arr[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    i++;
                    k--;
                }
            }

            return i - 1;
        }
    }
}
