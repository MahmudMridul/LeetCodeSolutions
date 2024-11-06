using Csharp.LC.Classes;
using Csharp.Medium;

namespace Csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListNode l1 = ListNode.CreateFromArray([9, 9, 9]);
            ListNode l2 = ListNode.CreateFromArray([9]);
            ListNode res = new LC_02().AddTwoNumbers(l1, l2);
            Console.WriteLine(string.Join(' ', ListNode.ToArray(res)));

        }
    }
}
