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
            int[] tArray = { -1, -1, 1, 1, 0, 0 };
            string tString = "(){}}{";
            int k = 2, threshold = 5;

            new LC_724().PivotIndex(tArray);
        }
    }
}
