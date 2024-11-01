using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Easy
{
    internal class ValidMountainArray_941
    {
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3) return false;
            int maxIndex = Array.IndexOf(arr, arr.Max());
            if (maxIndex == 0 || maxIndex == arr.Length - 1) return false;

            for (int i = maxIndex; i > 0; --i)
            {
                if (arr[i] <= arr[i - 1]) return false;
            }
            for (int i = maxIndex; i < arr.Length - 1; ++i)
            {
                if (arr[i] <= arr[i + 1]) return false;
            }
            return true;
        }
    }
}
