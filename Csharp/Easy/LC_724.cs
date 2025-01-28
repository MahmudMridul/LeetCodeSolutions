

namespace Csharp.Easy
{
    public class LC_724
    {
        public int PivotIndex(int[] nums)
        {
            if (nums.Length == 1) return 0;
            int len = nums.Length;
            int[] prefSum = new int[len];
            

            prefSum[0] = nums[0];
            for (int i = 1; i < len; ++i)
            {
                prefSum[i] = prefSum[i - 1] + nums[i];
            }

            if (prefSum[len - 1] - prefSum[0] == 0) return 0;
            
            int sumL = 0, sumR = 0;
            for (int i = 1; i < len - 1; ++i)
            {
                sumL = prefSum[i - 1];
                sumR = prefSum[len - 1] - prefSum[i];
                if (sumL == sumR) return i;
            }

            if (len >= 2 && prefSum[len - 2] == 0) return len - 1;

            return -1;
        }
    }
}
