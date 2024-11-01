namespace Csharp.Easy
{
    public class FindIndexOfFirstOccurance_28
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i < haystack.Length; ++i)
            {
                if (haystack[i] == needle[0])
                {
                    int h = i + 1, j = 1;
                    for (; j < needle.Length; ++j)
                    {
                        if (h == haystack.Length) break;
                        if (haystack[h] != needle[j])
                        {
                            break;
                        }
                        ++h;
                    }
                    if (j == needle.Length)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
