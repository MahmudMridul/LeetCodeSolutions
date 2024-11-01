namespace Csharp.Easy
{
    internal class DuplicateZeros_1089
    {
        public void DuplicateZeros(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                if (arr[i] == 0)
                {
                    RightShift(arr, i + 1);
                    arr[i + 1] = 0;
                    ++i;
                }
            }
        }

        private void RightShift(int[] arr, int start)
        {
            for (int i = arr.Length - 1; i > start; --i)
            {
                arr[i] = arr[i - 1];
            }
        }
    }
}
