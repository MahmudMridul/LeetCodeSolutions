
namespace Csharp.Medium
{
    public class LC_167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int L = 0, R = numbers.Length - 1, sum = 0;
            while (L < R)
            {
                sum = numbers[L] + numbers[R];
                if (sum == target)
                {
                    return new int[] { L + 1, R + 1 };
                }
                else if (sum < target)
                {
                    ++L;
                }
                else
                {
                    --R;
                }
            }
            return new int[] { };
        }
    }
}
