namespace Csharp.Easy
{
    internal class LeftRightSumDifference_2574
    {
        public int[] LeftRigthDifference(int[] nums)
        {
            int[] answer = new int[nums.Length];
            int leftSum = 0;
            int[] rightSum = new int[nums.Length];
            rightSum[rightSum.Length - 1] = 0;

            for (int i = answer.Length - 2; i >= 0; --i)
            {
                rightSum[i] = nums[i + 1] + rightSum[i + 1];
            }
            for (int i = 0; i < nums.Length; ++i)
            {
                if (i > 0)
                {
                    leftSum += nums[i - 1];
                }
                answer[i] = Math.Abs(leftSum - rightSum[i]);
            }
            return answer;
        }
    }
}
