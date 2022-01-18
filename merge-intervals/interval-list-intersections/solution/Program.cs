using System;
using System.Collections.Generic;

namespace solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] firstList = new int[][]
            {
                new int[] { 0, 2 },
                new int[] {5, 10},
                new int[] {13, 23},
                new int[] {24, 25}
            };

            int[][] secondList = new int[][]
            {
                new int[] { 1, 5 },
                new int[] {8, 12},
                new int[] {15, 24},
                new int[] {25, 26}
            };

            Solution sol = new Solution();
            sol.IntervalIntersection(firstList, secondList);
        }
    }

    public class Solution
    {
        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            List<int[]> result = new List<int[]>();
            int i = 0;
            int j = 0;

            while(i < firstList.Length && j < secondList.Length)
            {
                Intersect(firstList[i], secondList[j], result);

                if(firstList[i][1] < secondList[j][1])
                    j++;
                else
                    i++;
            }

            return result.ToArray();
        }

        private void Intersect(int[] interval1, int[] interval2, List<int[]> result)
        {
            int start = Math.Max(interval1[0], interval2[0]);
            int end = Math.Min(interval1[1], interval2[1]);

            if(end >= start)
            {
                result.Add(new int[] { start, end });
            }

        }
    }
}
