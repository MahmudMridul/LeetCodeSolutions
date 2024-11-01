namespace Csharp.Easy
{
    internal class HeightChecker_1051
    {
        public int HeightChecker(int[] heights)
        {
            int[] copy = (int[])heights.Clone();
            Array.Sort(copy);
            int count = 0;
            for (int i = 0; i < heights.Length; ++i)
            {
                if (heights[i] != copy[i]) ++count;
            }
            return count;
        }
    }
}
