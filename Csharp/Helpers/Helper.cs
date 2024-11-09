namespace Csharp.Helpers
{
    public class Helper
    {
        public static void PrintCollection<T>(IEnumerable<T> collection)
        {
            if (collection == null || collection.Count() == 0)
            {
                Console.WriteLine("Empty!");
                return;
            }
            foreach (var item in collection)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public static void PrintNestedCollection<T>(IEnumerable<IEnumerable<T>> collection)
        {
            if (collection == null || collection.Count() == 0)
            {
                Console.WriteLine("Empty!");
                return;
            }
            foreach (var innerCollection in collection)
            {
                foreach (var item in innerCollection)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
