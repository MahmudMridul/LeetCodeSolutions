using System.ComponentModel.Design;

namespace Csharp.Medium
{
    public class LC_15
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            if (nums[0] > 0)
            {
                return new List<IList<int>>();
            }

            IList<IList<int>> triplets = new List<IList<int>>();

            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] > 0)
                {
                    break;
                }
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int low = i + 1, high = nums.Length - 1;
                while (low < high)
                {
                    int sum = nums[i] + nums[low] + nums[high];
                    if (sum < 0)
                    {
                        ++low;
                    }
                    else if (sum > 0)
                    {
                        --high;
                    }
                    else if (sum == 0)
                    {
                        triplets.Add(new List<int> { nums[i], nums[low], nums[high] });
                        int lastLow = nums[low], lastHigh = nums[high];
                        while (low < high && nums[low] ==  lastLow)
                        {
                            ++low;
                        }
                        while (low < high && nums[high] == lastHigh)
                        {
                            --high;
                        }
                    }
                }
            }
            return triplets;
        }

        public IList<int> TwoSum(int[] nums, int target, int skipIndex)
        {
            Dictionary<int, int> set = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; ++i)
            {
                if (i != skipIndex && set.ContainsKey(target - nums[i]) && set[target - nums[i]] != i)
                {    
                    return new List<int>() { nums[i], target - nums[i] };   
                }
                else if (!set.ContainsKey(nums[i]) && i != skipIndex)
                {
                    set.Add(nums[i], i);
                }
            }
            return new List<int>();
        }
    }
}
 