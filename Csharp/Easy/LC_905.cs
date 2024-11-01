using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Easy
{
    internal class SortArrayByParity_905
    {
        public int[] SortArrayByParity(int[] nums)
        {
            return nums.OrderBy(n => n % 2 != 0).ToArray();
        }
    }
}
