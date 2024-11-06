namespace Csharp.LC.Classes
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode CreateFromArray(int[] nums)
        {
            ListNode head = new ListNode(nums[0]);
            ListNode pointer = head;
            for (int i = 1; i < nums.Length; ++i)
            {
                ListNode node = new ListNode(nums[i]);
                pointer.next = node;
                pointer = node;
            }
            return head;
        }

        public static int[] ToArray(ListNode head)
        {
            List<int> list = new List<int>();
            ListNode pointer = head;

            while (pointer != null)
            {
                list.Add(pointer.val);
                pointer = pointer.next;
            }
            return list.ToArray();
        }
    }
}
