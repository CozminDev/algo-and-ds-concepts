using System.Linq;

namespace solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] interval = new int[][]
            {
                new int[] { 1, 100 },
                new int[] {11, 22},
                new int[] {1, 11},
                new int[] {2, 12}
            };

            Solution sol = new Solution();
            sol.EraseOverlapIntervals(interval);
        }
    }

    public class Solution
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            intervals = intervals.OrderBy(x => x[0]).ToArray();

            if (intervals.Length == 1)
                return 0;

            int i = 0;
            int j = 1;
            int count = 0;

            while(j < intervals.Length)
            {
                if(intervals[i][1] <= intervals[j][0])
                {
                    i = j;
                    j++;
                }
                else if (intervals[i][1] <= intervals[j][1])
                {
                    j++;
                    count++;
                }
                    
                else if (intervals[i][1] > intervals[j][1])
                {
                    i = j;
                    j++;
                    count++;
                }
            }

            return count;
        }
    }
}
