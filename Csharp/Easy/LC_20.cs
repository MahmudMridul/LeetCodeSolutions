
namespace Csharp.Easy
{
    public class LC_20
    {
        public bool IsValid(string s)
        {
            if (s.Length == 1) return false;
            if (s[0] == ')' || s[0] == '}' || s[0] == ']') return false;

            Stack<char> paren = new Stack<char>();

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    paren.Push(s[i]);
                }
                else if (s[i] == ')' && paren.Count > 0 && paren.Peek() == '(') { paren.Pop(); }
                else if (s[i] == '}' && paren.Count > 0 && paren.Peek() == '{') { paren.Pop(); }
                else if (s[i] == ']' && paren.Count > 0 && paren.Peek() == '[') { paren.Pop(); }
                else { return false; }
            }
            return paren.Count == 0;
        }
    }
}
