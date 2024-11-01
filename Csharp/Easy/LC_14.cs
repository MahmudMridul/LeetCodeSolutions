
using System.Text;

namespace Csharp.Easy
{
    public class LongestCommonPrefix_14
    {
        // 91ms 40.22MB
        public string LongestCommonPrefix_v1(string[] strs)
        {
            StringBuilder result = new StringBuilder();
            int minLength = strs.Min(str => str.Length);

            for (int i = 0; i < minLength; ++i)
            {
                char first = strs[0][i];
                bool isCommon = true;
                for (int j = 1; j < strs.Length; ++j)
                {
                    if (first != strs[j][i])
                    {
                        isCommon = false;
                        break;
                    }
                }
                if (isCommon)
                {
                    result.Append(first);
                }
                else { break; }
            }
            return result.ToString();
        }

        // 88ms 40.70MB
        public string LongestCommonPrefix_v2(string[] strs)
        {
            int minLength = strs.Min(str => str.Length);
            string result = strs.FirstOrDefault(str => str.Length == minLength);

            for (int i = 0; i < strs.Length; ++i)
            {
                while (!strs[i].StartsWith(result))
                {
                    result = result.Remove(result.Length - 1);
                }
            }
            return result;
        }
    }
}
