using Csharp.Helpers;
using Csharp.LC.Classes;
using Csharp.Medium;

namespace Csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] tArray = { 1, 2, 3, 4, 5 };
            string tString = "2";

            ListNode head = ListNode.CreateFromArray(tArray);
            ListNode result = new LC_19().RemoveNthFromEnd(head, 5);
            Helper.PrintCollection(ListNode.ToArray(result));
        }
    }
}
