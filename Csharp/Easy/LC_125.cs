using System.Text.RegularExpressions;

namespace Csharp.Easy
{
    public class LC_125
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            string str = Regex.Replace(s, "[^a-zA-Z0-9]", "");

            int left = 0, right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right]) return false;
                ++left; --right;
            }
            return true;
        }
    }
}
