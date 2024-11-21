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
            int[] tArray = { 9, 4, 2, 10, 7, 8, 8, 1, 9 };
            string tString = "2";
            int var = new LC_978().MaxTurbulenceSize(tArray);
            Console.WriteLine(var.ToString());
        }
    }
}
