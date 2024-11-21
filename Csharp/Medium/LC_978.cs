namespace Csharp.Medium
{
    public class LC_978
    {
        public int MaxTurbulenceSize(int[] arr)
        {
            int left = 0, right = 1, max = 1;
            char sign = '=';

            while (right < arr.Length)
            {
                if (arr[right - 1] < arr[right] && sign != '<')
                {
                    max = Math.Max(max, right - left + 1);
                    sign = '<';
                    ++right;
                }
                else if (arr[right - 1] > arr[right] && sign != '>')
                {
                    max = Math.Max(max, right - left + 1);
                    sign = '>';
                    ++right;
                }
                else
                {
                    right = arr[right - 1] == arr[right] ? right + 1 : right;
                    left = right - 1;
                    sign = '=';
                }
            }
            return max;
        }
    }
}
