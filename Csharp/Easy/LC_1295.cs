namespace Csharp.Easy
{
    internal class FindNumbersWithEvenNumberOfDigits_1295
    {
        public int FindNumbers(int[] nums)
        {
            return nums.Count(num => num.ToString().Length % 2 == 0);
        }


    }
}
