using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Easy
{
    internal class ReplaceElementsWithGreatestOnRightSide_1299
    {
        public int[] ReplaceElements_v2(int[] arr)
        {
            int max = arr[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; --i)
            {
                int temp = arr[i];
                arr[i] = max;
                max = Math.Max(max, temp);
            }
            arr[arr.Length - 1] = -1;
            return arr;
        }

        public int[] ReplaceElements_v1(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                arr[i] = FindMax(arr, i + 1);
            }
            arr[arr.Length - 1] = -1;
            return arr;
        }

        private int FindMax(int[] arr, int start)
        {
            return arr.Skip(start).Max();
        }
    }
}
