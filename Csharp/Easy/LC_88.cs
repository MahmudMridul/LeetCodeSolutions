using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Easy
{
    internal class MergeSortedArray_88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int j = 0;
            for (int i = m; i < nums1.Length; ++i)
            {
                nums1[i] = nums2[j];
                ++j;
            }
            Array.Sort(nums1);
        }
    }
}
