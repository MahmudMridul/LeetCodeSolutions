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
            int[] tArray = { 5, -3, 5 };
            string tString = "2";
            int val = new ArrayAlgos().Kadane(tArray);
            Console.WriteLine(val);
            
        }
    }
}
