using Csharp.Easy;

namespace Csharp.Medium
{
    public class LC_1343
    {
        public int NumOfSubarrays(int[] arr, int k, int threshold)
        {
            double average = 0;
            int sum = 0, result = 0, left = 0, right = left + k - 1;
            for (int i = 0; i < k; ++i)
            {
                sum += arr[i];
            }
            average = sum*1.0 / k*1.0;
            
            while (right < arr.Length)
            {
                result = average >= threshold ? result + 1 : result;
                ++left;
                if (right + 1 < arr.Length)
                {
                    ++right;
                }
                else break;
                sum -= arr[left - 1];
                sum += arr[right];
                average = sum * 1.0 / k * 1.0;
            }
            return result;
        }
    }
}
