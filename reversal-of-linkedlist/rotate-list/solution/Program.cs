using System;

namespace solution
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(0);
            ListNode current = head;
            for(int i = 1; i <= 2; i++)
            {
                current.next = new ListNode(i);
                current = current.next;
            }

            Solution sol = new Solution();
            sol.RotateRight(head, 4);
        }

    }

    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null)
                return head;

            int num = NumOfNodes(head);

            k = k % num;

            if (k == 0)
                return head;

            ListNode currentHead = head;
            for(int i = 0; i< k; i++)
            {
                ListNode last = currentHead;
                ListNode prev = null;
                while (last.next != null)
                {
                    prev = last;
                    last = last.next;
                }

                prev.next = null;

                last.next = currentHead;
                currentHead = last;
            }

            return currentHead;
        }

        private int NumOfNodes(ListNode head)
        {
            int num = 0;
            ListNode pointer = head;
            while (pointer != null)
            {
                pointer = pointer.next;
                num++;
            }

            return num;
        }
    }
}
