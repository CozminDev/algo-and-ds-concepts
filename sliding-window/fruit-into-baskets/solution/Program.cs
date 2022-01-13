using System;
using System.Collections.Generic;

namespace solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine(sol.TotalFruit(new int[] { 0, 1, 2, 2 }));
        }
    }

    class Solution
    {
        public int TotalFruit(int[] fruits)
        {
            int i = 0;
            int j = 0;
            int max = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();

            while (j < fruits.Length)
            {
                if (!dic.ContainsKey(fruits[j]))
                    dic.Add(fruits[j], 1);
                else
                    dic[fruits[j]]++;

                if (dic.Count > 2)
                {
                    dic[fruits[i]]--;

                    if (dic[fruits[i]] == 0)
                        dic.Remove(fruits[i]);

                    i++;
                }

                j++;
                max = Math.Max(max, j - i);
            }

            return max;
        }
    }
}
