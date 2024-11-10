using Csharp.Helpers;
using Csharp.Medium;

namespace Csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] tArray = { 0, 0, 0 };
            string tString = "2";

            var list = new LC_17().LetterCombinations(tString);
            Helper.PrintCollection(list);
        }
    }
}
