using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Easy
{
    internal class RemoveDuplicatesFromSortedArray_26
    {
        public int RemoveDuplicates(int[] nums)
        {
            int pointer = 1;
            int lastSeen = nums[0];
            for (int i = 1; i < nums.Length; ++i)
            {
                if (nums[i] != lastSeen)
                {
                    nums[pointer] = nums[i];
                    ++pointer;
                    lastSeen = nums[i];
                }
            }
            return pointer;
        }
    }
}
