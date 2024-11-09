using Csharp.Helpers;
using Csharp.Medium;

namespace Csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] test = { 0, 0, 0 };
            
            var sum = new LC_16().ThreeSumClosest(test, 1);
            Console.WriteLine(sum);
        }
    }
}
