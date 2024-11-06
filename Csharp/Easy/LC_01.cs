namespace Csharp.Easy
{
    internal class LC_01
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> list = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; ++i) 
            {
                if (list.ContainsKey(nums[i]) && list.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, list[target - nums[i]] };                    
                }
                else
                {
                    list.Add(nums[i], i);
                }
            }
            return new int[] { };
        }
    }
}
