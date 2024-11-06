using Csharp.LC.Classes;

namespace Csharp.Medium
{
    public class InsertGCDInLinkedList_2807
    {
        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            if (head.next == null) return head;
            ListNode pointer = head;

            while (pointer.next != null)
            {
                int a = pointer.val, b = pointer.next.val;
                int gcd = Gcd(a, b);
                ListNode node = new ListNode(gcd);

                node.next = pointer.next;
                ListNode tempPointer = pointer;
                pointer = pointer.next;
                tempPointer.next = node;
            }
            return head;
        }

        private int Gcd(int a, int b)
        {
            if (a == 0) return b;
            return Gcd(b % a, a);
        }
    }
}
