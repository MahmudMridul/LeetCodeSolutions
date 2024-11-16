namespace Csharp.Algorithms.Arrays
{
    public class ArrayAlgos
    {
        public int Kadane(int[] nums)
        {
            int maxSum = nums[0], maxEnding = 0;

            for(int i = 0; i < nums.Length; ++i)
            {
                maxEnding = Math.Max(maxEnding + nums[i], nums[i]);
                maxSum = Math.Max(maxSum, maxEnding);
            }
            return maxSum;
        }
    }
}
