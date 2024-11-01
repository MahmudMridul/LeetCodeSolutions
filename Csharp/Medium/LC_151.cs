
using System.Text;

namespace Csharp.Medium
{
    public class ReverseWordsInAString_151
    {
        // 71ms 38.8MB      
        public string ReverseWords(string s)
        {
            s = RemoveExtraSpaces(s);
            string[] words = s.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; --i)
            {
                sb.Append(words[i]);
                if (i != 0)
                {
                    sb.Append(' ');
                }
            }
            return sb.ToString();
        }

        public string RemoveExtraSpaces(string s)
        {
            s = s.Trim();
            StringBuilder str = new StringBuilder();
            int space = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == ' ')
                {
                    ++space;
                    if (space == 1)
                    {
                        str.Append(' ');
                    }
                }
                if (s[i] != ' ')
                {
                    str.Append(s[i]);
                    space = 0;
                }
            }
            return str.ToString();
        }
    }
}
