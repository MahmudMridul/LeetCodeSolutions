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
            string tString = "AABABCACCC";
            int k = 2, threshold = 5;

            int val = new LC_424().CharacterReplacement(tString, k);
            Console.WriteLine(val);
        }
    }
}
