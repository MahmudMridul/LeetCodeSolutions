using Csharp.Helpers;
using Csharp.Medium;

namespace Csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] test = { -1, 0, 1, 2, -1, -4 };
            
            var list = new LC_15().ThreeSum(test);
            Helper.PrintNestedCollection(list);
        }
    }
}
