using Csharp.Algorithms.Arrays;
using Csharp.Helpers;
using Csharp.LC.Classes;
using Csharp.Medium;

namespace Csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] tArray = { 11, 13, 17, 23, 29, 31, 7, 5, 2, 3 };
            string tString = "pwwkew";
            int k = 3, threshold = 5;

            int val = new LC_03().LengthOfLongestSubstring(tString);
            Console.WriteLine(val);
        }
    }
}
