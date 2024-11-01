using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Easy
{
    internal class SquaresOfASortedArray_977
    {
        public int[] SortedSquares(int[] nums)
        {
            return nums.Select(num => num * num).ToArray();
        }
    }
}
