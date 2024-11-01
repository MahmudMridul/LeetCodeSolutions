using System.Text;

namespace Csharp.Medium
{
    public class IntegerToRoman_12
    {
        private Dictionary<int, string> map = new Dictionary<int, string>()
        {
            { 1, "I" },
            { 2, "II" },
            { 3, "III" },
            { 4, "IV" },
            { 5, "V" },
            { 6, "VI" },
            { 7, "VII" },
            { 8, "VIII" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },
            { 400, "CD" },
            { 500, "D" },
            { 900, "CM" },
            { 1000, "M" }
        };

        private int[] keys = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

        public string IntToRoman_v1(int num)
        {
            Stack<string> stack = new Stack<string>();
            if (map.ContainsKey(num)) { return map[num]; }

            int mod = 10;
            while (num > 0)
            {

                int needToFind = num % mod;
                if (map.ContainsKey(needToFind))
                {
                    stack.Push(map[needToFind]);
                }
                else
                {
                    string roman = FindRoman(needToFind);
                    stack.Push(roman);
                }
                num -= needToFind;
                mod *= 10;
            }

            return string.Join("", stack);
        }

        private string FindRoman(int needToFind)
        {
            StringBuilder sb = new StringBuilder();
            while (needToFind > 0)
            {
                int n = LargestSmallerEqualToN(needToFind);
                sb.Append(map[n]);
                needToFind -= n;
            }
            return sb.ToString();
        }

        private int LargestSmallerEqualToN(int n)
        {
            for (int i = 0; i < keys.Length; ++i)
            {
                if (keys[i] > n)
                {
                    return keys[i - 1];
                }
            }
            return 1000;
        }

        public string IntToRoman(int num)
        {
            string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < values.Length; ++i)
            {
                while (num >= values[i])
                {
                    sb.Append(roman[i]);
                    num -= values[i];
                }
            }
            return sb.ToString();
        }
    }
}
