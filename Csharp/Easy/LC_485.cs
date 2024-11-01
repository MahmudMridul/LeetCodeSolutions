namespace Csharp.Easy
{
    internal class MaxConsecutiveOnes_485
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0, max = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] == 1)
                {
                    ++count;
                }
                else
                {
                    max = Math.Max(max, count);
                    count = 0;
                }
            }
            max = Math.Max(max, count);
            return max;
        }
    }
}
