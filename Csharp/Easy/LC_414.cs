using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Easy
{
    internal class ThirdMaximumNumber_414
    {
        public int ThirdMax(int[] nums)
        {
            int[] val = nums
                    .Distinct()
                    .OrderBy(n => n)
                    .TakeLast(3)
                    .ToArray();
            return val.Length < 3 ? val[val.Length - 1] : val[0];
        }
    }
}
