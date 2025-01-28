

namespace Csharp.Easy
{
    public class LC_303
    {

    }

    public class NumArray
    {
        public int[] _nums;
        public int[] _sums;

        public NumArray(int[] nums)
        {
            _nums = nums;
            _sums = new int[nums.Length];
            _sums[0] = nums[0];
            for (int i = 1; i < nums.Length; ++i)
            {
                _sums[i] = _sums[i - 1] + nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            if (left == right) return _nums[left];
            else if (left == 0 && right > 0) return _sums[right];
            else return _sums[right] - _sums[left - 1];
        }
    }
}
