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
