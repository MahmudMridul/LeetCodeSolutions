using System.Text;

namespace Csharp.Easy
{
    internal class DecodeTheMessage_2325
    {
        public string DecodeMessage(string key, string message)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();
            char k = 'a';
            for(int i = 0; i < key.Length; ++i)
            {
                if (key[i] != ' ' && !map.ContainsKey(key[i]))
                {
                    map[key[i]] = k;
                    ++k;
                }
                if (map.Count >= 26) break;
            }
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < message.Length; ++i)
            {
                if (message[i] == ' ')
                {
                    sb.Append(' ');
                }
                else
                {
                    sb.Append(map[message[i]]);
                }
            }
            
            return sb.ToString();
        }
    }
}
