using System.Text;

namespace Csharp.Medium
{
    public class LC_06
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1 || s.Length == numRows) return s;
            List<string>[] matrix = new List<string>[numRows];

            for(int i = 0; i < matrix.Length; ++i)
            {
                matrix[i] = new List<string>();
            }

            int pointer = 0;
            bool goDown = true;
            for(int i = 0; i < s.Length; ++i)
            {
                char c = s[i];
                matrix[pointer].Add("" + c);

                if (pointer == numRows - 1) goDown = false;
                if (pointer ==  0) goDown = true;

                pointer = goDown ? pointer + 1 : pointer - 1; 
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < matrix.Length; ++i)
            {
                List<string> row = matrix[i];
                for(int j = 0; j < row.Count; ++j)
                {
                    sb.Append(row[j]);
                }
            }

            return sb.ToString();
        }
    }
}
