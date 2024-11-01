using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Medium
{
    internal class LetterCombinationsOfAPhoneNumber_17
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits)) return new List<string>();

            Dictionary<char, string> map = GetMapping();

            return new List<string>();
        }

        private Dictionary<char, string> GetMapping()
        {
            Dictionary<char, string> mapping = new Dictionary<char, string>();
            char value = 'a';
            for (char key = '2'; key <= '9'; ++key)
            {
                int limit = 3;
                if (key == '7' || key == '9')
                {
                    limit = 4;
                }
                StringBuilder sb = new StringBuilder();
                int count = 1;
                while (count <= limit)
                {
                    sb.Append(value);
                    ++value;
                    ++count;
                }
                mapping[key] = sb.ToString();
            }
            return mapping;
        }
    }
}
