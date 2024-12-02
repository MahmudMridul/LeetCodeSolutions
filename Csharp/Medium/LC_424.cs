namespace Csharp.Medium
{
    public class LC_424
    {
        public int CharacterReplacement(string s, int k)
        {
            int left = 0, maxLen = 1, maxFreq = 0; 
            int[] counts = new int[26];
            for (int right = 0; right < s.Length; ++right)
            {
                maxFreq = Math.Max(maxFreq, ++counts[s[right] - 'A']);
                while (right - left + 1 - maxFreq > k)
                {
                    --counts[s[left] - 'A'];
                    ++left;
                }
                maxLen = Math.Max(maxLen, right - left + 1);
            }
            return maxLen;
        }
    }
}
