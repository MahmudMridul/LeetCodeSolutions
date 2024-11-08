using System.Formats.Tar;

namespace Csharp.Medium
{
    public class LC_209
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int left = 0, right = 0, windowSum = 0, size = int.MaxValue;

            while (right < nums.Length)
            {
                windowSum += nums[right];
                while (windowSum >= target)
                {
                    size = Math.Min(size, right - left + 1);
                    windowSum -= nums[left];
                    ++left;
                }
                ++right;
            }
            return size == int.MaxValue ? 0 : size;
        }
    }
}
