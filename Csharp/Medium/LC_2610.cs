namespace Csharp.Medium
{
    public class ConvertArrayTo2D_2610
    {
        public IList<IList<int>> FindMatrix(int[] nums)
        {
            IList<IList<int>> twoD = new List<IList<int>>();
            int[] count = GetCountArray(nums);
            int total = nums.Length;
            while (total > 0)
            {
                IList<int> list = new List<int>();
                for (int i = 1; i < count.Length; ++i)
                {
                    if (count[i] > 0)
                    {
                        list.Add(i);
                        --count[i];
                        --total;
                    }
                }
                twoD.Add(list);
            }
            return twoD;
        }

        private int[] GetCountArray(int[] nums)
        {
            int[] count = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; ++i)
            {
                ++count[nums[i]];
            }
            return count;
        }
    }
}
