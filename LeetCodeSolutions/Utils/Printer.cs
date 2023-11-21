
namespace LeetCodeSolutions.Utils
{
    public static class Printer
    {
        public static void Print<T>(IEnumerable<T> list)
        {
            if(!list.Any()) { Console.WriteLine("List is empty!"); }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
