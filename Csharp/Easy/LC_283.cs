using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Easy
{
    internal class MoveZeroes_283
    {
        public void MoveZeroes(int[] nums)
        {
            int pointer = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] != 0)
                {
                    nums[pointer] = nums[i];
                    ++pointer;
                }
            }
            while (pointer < nums.Length)
            {
                nums[pointer] = 0;
                ++pointer;
            }
        }
    }
}
