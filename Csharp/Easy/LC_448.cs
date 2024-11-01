namespace Csharp.Easy
{
    internal class FindDisappearedNumbers_448
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> result = new List<int>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; ++i)
            {
                if (Array.BinarySearch(nums, i + 1) < 0)
                {
                    result.Add(i + 1);
                }
            }
            return result;
        }
    }
}
