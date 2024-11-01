namespace Csharp.Medium
{
    public class SortVowelsInString_2785
    {
        public string SortVowels(string s)
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            char[] chars = s.ToCharArray();
            List<int> indexes = new List<int>();
            List<char> vowelChars = new List<char>();

            for (int i = 0; i < s.Length; ++i)
            {
                char c = s[i];
                if (vowels.Contains(c))
                {
                    indexes.Add(i);
                    vowelChars.Add(c);
                }
            }
            if (vowelChars.Count == 0) return s;
            vowelChars.Sort();

            int p = 0;
            for (int i = 0; i < indexes.Count; ++i)
            {
                chars[indexes[i]] = vowelChars[p];
                ++p;
            }
            return string.Join("", chars);
        }
    }
}
