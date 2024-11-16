
namespace Csharp.Medium
{
    public class LC_53
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0], maxEnding = 0;

            for(int i = 0; i < nums.Length; ++i)
            {
                maxEnding = Math.Max(maxEnding + nums[i], nums[i]);
                maxSum = Math.Max(maxEnding, maxSum);
            }
            return maxSum;
        }
    }
}
