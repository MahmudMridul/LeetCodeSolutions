namespace Csharp.Medium
{
    public class LC_17
    {
        private Dictionary<char, string> keyMap = new Dictionary<char, string>()
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" },
        };

        private List<string> keyList = new List<string>();
        private List<string> combination = new List<string>();

        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits)) return new List<string>();

            combination.Clear();
            for (int i = 0; i < digits.Length; ++i)
            {
                keyList.Add(keyMap[digits[i]]);
            }

            for (int i = 0; i < keyList[0].Length; ++i)
            {
                FindCombination(1, "" + keyList[0][i]);
            }
            
            return combination;
        }

        public void FindCombination(int keyListInd, string s)
        {
            if (keyListInd >= keyList.Count)
            {
                combination.Add(s);
                return;
            };

            for (int i = 0; i < keyList[keyListInd].Length; ++i)
            {
                string str = s + keyList[keyListInd][i];
                FindCombination(keyListInd + 1, str);
            }
        }
    }
}
