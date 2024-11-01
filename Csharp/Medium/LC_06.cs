using System.Text;

namespace Csharp.Medium
{
    public class ZigzagConversion_6
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }
            if (numRows == 2)
            {
                return SpecialCase(s, s.Length);
            }
            int size = s.Length;
            int numCols = GetNumberOfColumns(size, numRows);
            Console.WriteLine($"ROWS: {numRows} COLS: {numCols}");

            char[,] chars = Create2DArray(s, size, numRows, numCols);
            Print(chars);


            return "";
        }

        private string SpecialCase(string s, int size)
        {
            StringBuilder sb = new StringBuilder();
            for (int ch = 0; ch < size; ch += 2)
            {
                sb.Append(s[ch]);
            }
            for (int ch = 1; ch < size; ch += 2)
            {
                sb.Append(s[ch]);
            }
            return sb.ToString();
        }

        private char[,] Create2DArray(string s, int size, int rows, int cols)
        {
            char[,] chars = new char[rows, cols];
            int ch = 0;
            int col = 0;
            while (ch < size)
            {
                for (int r = 0; r < rows; ++r)
                {
                    //if (ch >= size) break;
                    //chars[r, col] = s[ch];
                    ++ch;
                    Console.WriteLine($"ROW: {r} COL: {col}");
                }
                ++col;
                for (int r = rows - 2; r >= 0; --r)
                {
                    //if (ch >= size) break;
                    //chars[r, col] = s[ch];
                    ++ch;
                    //++col;




                    Console.WriteLine($"ROW: {r} COL: {col}");
                }
            }
            return chars;
        }

        private int GetNumberOfColumns(int size, int rows)
        {
            int cols = 0;
            while (size > 0)
            {
                if (size - rows >= 0)
                {
                    ++cols;
                    size -= rows;
                }
                else
                {
                    ++cols;
                    break;
                }

                if (size - (rows - 2) >= 0)
                {
                    cols += rows - 2;
                    size -= rows - 2;
                }
                else
                {
                    cols += size;
                    break;
                }
            }
            return cols;
        }

        private void Print(char[,] chars)
        {
            for (int r = 0; r < chars.GetLength(0); ++r)
            {
                for (int c = 0; c < chars.GetLength(1); ++c)
                {
                    Console.Write(chars[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
