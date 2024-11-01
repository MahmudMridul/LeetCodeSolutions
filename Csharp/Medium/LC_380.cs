namespace Csharp.Medium
{
    public class RandomizedSet_380
    {
        private Random rand;
        private HashSet<int> set;
        public RandomizedSet_380()
        {
            rand = new Random();
            set = new HashSet<int>(200000);
        }

        public bool Insert(int val)
        {
            return set.Add(val);
        }

        public bool Remove(int val)
        {
            return set.Remove(val);
        }

        public int Count()
        {
            return set.Count;
        }

        public int GetRandom()
        {
            int index = rand.Next(set.Count);
            return set.ElementAt(index);
        }
    }
}
