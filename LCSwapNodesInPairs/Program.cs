using System;

namespace LCSwapNodesInPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);

            ListNode swappedList = SwapPairs(head);

            while (swappedList != null)
            {
                Console.WriteLine(swappedList.val);
                swappedList = swappedList.next;
            }

            ListNode SwapPairs(ListNode head)
            {
                ListNode swappedList = new ListNode(0);
                swappedList.next = head;

                ListNode previousNode = swappedList;
                ListNode currentNode = head;

                while (currentNode != null && currentNode.next != null)
                {
                    ListNode tempNode = currentNode.next.next;

                    previousNode.next = currentNode.next;
                    previousNode.next.next = currentNode;
                    currentNode.next = tempNode;

                    previousNode = currentNode;
                    currentNode = tempNode;
                }

                return swappedList.next;
            }
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
