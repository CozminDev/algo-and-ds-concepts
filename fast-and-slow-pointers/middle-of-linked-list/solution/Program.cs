using System;

namespace solution
{


    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.MiddleNode(CreateNode(6)).val);
        }

        static ListNode CreateNode(int count)
        {
            ListNode head = new ListNode();

            ListNode pointer = head;
            int i = 0;
            while (i < count)
            {
                pointer.val = i + 1;

                if (i < count - 1)
                {
                    pointer.next = new ListNode();

                    pointer = pointer.next;
                }

                i++;
            }

            return head;
        }
    }

    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
