using Csharp.Algorithms.Arrays;
using Csharp.Easy;
using Csharp.Helpers;
using Csharp.LC.Classes;
using Csharp.Medium;

namespace Csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] tArray = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            string tString = "  ";
            int k = 2, threshold = 5;

            var v = new LC_26().RemoveDuplicates(tArray);
            Console.WriteLine(v);
        }
    }
}
