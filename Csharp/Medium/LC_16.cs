namespace Csharp.Medium
{
    public class LC_16
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int result = 0, d = int.MaxValue;

            for (int i = 0; i < nums.Length; ++i)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int low = i + 1, high = nums.Length - 1;
                while (low < high)
                {
                    int sum = nums[i] + nums[low] + nums[high];
                    int diff = int.Abs(sum - target);
                    result = diff < d ? sum : result;
                    d = diff < d ? diff : d;

                    if (sum < target)
                    {
                        ++low;
                    }
                    else if (sum > target)
                    {
                        --high;
                    }
                    else
                    {
                        return sum;
                    }
                }
            }
            return result;
        }
    }
}
