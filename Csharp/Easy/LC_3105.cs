
namespace Leetcode.Easy
{
    public class LC_3105
    {
        public int LongestMonotonicSubarray(int[] nums)
        {
            int inc = 1, maxInc = 1, dec = 1, maxDec = 1;

            for (int i = 1; i < nums.Length; ++i)
            {
                if (nums[i] > nums[i - 1]) ++inc;
                else
                {
                    maxInc = Math.Max(maxInc, inc);
                    inc = 1;
                }

                if (nums[i] < nums[i - 1]) ++dec;
                else
                {
                    maxDec = Math.Max(maxDec, dec);
                    dec = 1;
                }
            }
            maxInc = Math.Max(maxInc, inc);
            maxDec = Math.Max(maxDec, dec);
            return Math.Max(maxInc, maxDec);
        }
    }
}
