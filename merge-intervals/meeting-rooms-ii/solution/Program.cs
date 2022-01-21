using System;
using System.Linq;
using utility_library;

namespace solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] intervals = new int[][]
            {
                new int[] { 0, 30 },
                new int[] {5, 10},
                new int[] {15, 20}
            };

            int[][] intervals2 = new int[][]
            {
                new int[] { 7, 10 },
                new int[] {2, 4},
            };

            Solution sol = new Solution();
            sol.MinMeetingRooms(intervals2);
        }

        public class Solution
        {
            public int MinMeetingRooms(int[][] intervals)
            {
                intervals = intervals.OrderBy(x => x[0]).ToArray();
                PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

                foreach (int[] interval in intervals)
                {
                    if (pq.Count() == 0 || interval[0] < pq.PeekMin())
                    {
                        pq.Enqueue(interval[1], interval[1]);
                        continue;
                    }

                    if (interval[0] > pq.PeekMin())
                    {
                        pq.DequeueMin();
                        pq.Enqueue(interval[1], interval[1]);
                    }
                        
                }

                return pq.Count();
            }
        }
    }


}
