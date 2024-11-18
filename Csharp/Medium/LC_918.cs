namespace Csharp.Medium
{
    public class LC_918
    {
        public int MaxSubarraySumCircular(int[] nums)
        {
            int maxSum = nums[0], minSum = nums[0], total = 0, maxEnding = 0, minEnding = 0;
            for(int i = 0; i < nums.Length; ++i)
            {
                maxEnding = Math.Max(maxEnding + nums[i], nums[i]);
                maxSum = Math.Max(maxEnding, maxSum);

                minEnding = Math.Min(minEnding + nums[i], nums[i]);
                minSum = Math.Min(minEnding, minSum);

                total += nums[i];
            }
            return maxSum > 0 ? Math.Max(maxSum, total - minSum) : maxSum;
        }
    }
}
