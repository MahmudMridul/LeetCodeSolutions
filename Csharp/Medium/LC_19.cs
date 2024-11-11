
using Csharp.LC.Classes;

namespace Csharp.Medium
{
    public class LC_19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int size = Count(head);
            if (size == 1 && n == 1) return null;
            if (size == n)
            {
                head = head.next;
                return head;
            }

            int toDelete = size - n + 1, p = 1;
            ListNode pointer = head;

            while (true)
            {
                if (p == toDelete - 1)
                {
                    pointer.next = pointer.next.next == null ? null : pointer.next.next;
                    break;
                }
                ++p;
                pointer = pointer.next;
            }
            return head;
        }

        public int Count(ListNode head)
        {
            int count = 0;
            ListNode pointer = head;
            while (pointer != null)
            {
                ++count;
                pointer = pointer.next;
            }
            return count;
        }
    }
}
