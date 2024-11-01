namespace Csharp.Medium
{
    public class MaximumTwinSum_2130
    {
        public int PairSum(ListNode head)
        {
            IList<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            int left = 0, right = list.Count - 1, twinSum = int.MinValue;
            while (left < right)
            {
                twinSum = Math.Max(list[left] + list[right], twinSum);
                ++left;
                --right;
            }
            return twinSum;
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
}
