namespace Csharp.Medium
{
    public class LC_11
    {
        public int MaxArea(int[] height)
        {
            if (height.Length == 2) return Math.Min(height[0], height[1]);
            
            int maxArea = 0, left = 0, right = height.Length - 1;

            while (left < right )
            {
                int area = (Math.Abs(left - right)) * (Math.Min(height[left], height[right]));
                maxArea = Math.Max(maxArea, area);

                if (height[left] < height[right])
                {
                    ++left;
                }
                else
                {
                    --right;
                }
            }
            return maxArea;
        }
    }
}
