using Csharp.LC.Classes;

namespace Csharp.Medium
{
    internal class LC_02
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int sum = l1.val + l2.val, inHand = sum >= 10 ? 1 : 0;
            sum %= 10;
            ListNode node = new ListNode(sum);
            ListNode n = node;
            l1 = l1.next; l2 = l2.next;
            
            while (l1 != null || l2 != null)
            {
                sum = inHand + (l1 == null ? 0 : l1.val) + (l2 == null ? 0: l2.val);// modding sum early
                inHand = sum >= 10 ? 1 : 0;
                sum %= 10;
                ListNode l = new ListNode(sum);
                n.next = l;
                n = l;
                l1 = l1 == null ? l1 : l1.next;
                l2 = l2 == null ? l2: l2.next;
            }
            if (inHand > 0)
            {
                ListNode ln = new ListNode(inHand);
                n.next = ln;
            }
            return node;
        }
    }
}
