
namespace Csharp.Medium
{
    internal class LC_05
    {
        public string LongestPalindrome(string s)
        {
            string odd = CheckForOddLength(s);
            string even = CheckForEvenLength(s);
            return odd.Length > even.Length ? odd : even;
        }

        private string CheckForOddLength(string s)
        {
            int maxLen = 1, start = 0, end = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                int left = i - 1, right = i + 1, currLen = 1;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    currLen += 2;
                    if (currLen > maxLen)
                    {
                        maxLen = currLen;
                        start = left;
                        end = right;
                    }
                    --left;
                    ++right;
                }
            }
            return maxLen > 1 ? s.Substring(start, end - start + 1) : s[0].ToString();
        }

        private string CheckForEvenLength(string s)
        {
            int maxLen = 0, start = 0, end = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                int left = i, right = i + 1, currLen = right - left + 1;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    currLen = right - left + 1;
                    if (currLen > maxLen)
                    {
                        maxLen = currLen;
                        start = left;
                        end = right;
                    }
                    --left;
                    ++right;
                }
            }
            return maxLen > 1 ? s.Substring(start, end - start + 1) : s[0].ToString();
        }
    }
}
