namespace Csharp.Medium
{
    public class LC_03
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int longest = 1, left = 0, right = 1, size = 1;

            int[] count = new int[256];
            ++count[s[0]];

            while (right <  s.Length)
            {
                if (count[s[right]] > 0)
                {
                    --count[s[left]];
                    ++left;
                }
                else
                {
                    ++count[s[right]];
                    size = right - left + 1;
                    longest = Math.Max(longest, size);
                    ++right;
                }
            }
            return longest;
        }
    }
}
