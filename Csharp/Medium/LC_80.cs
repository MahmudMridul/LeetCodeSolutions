
namespace Csharp.Medium
{
    public class LC_80
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 3) return nums.Length;
            // j keeps track of valid part of the array
            // number of j elements is valid
            // from 0 to j - 1 is the index of valid elements
            // also j is the position where next valid element will be placed
            int j = 2; 
            // since upto j - 1 index array is valid so we start i from 2
            // i will check each element if it can be added to valid part
            // the if condition checks if current element can be added by checking 
            // current element != the element two position before where next valid element will be placed [max 2 occurances]
            for (int i = 2; i < nums.Length; ++i)
            {
                if (nums[i] != nums[j - 2])
                {
                    nums[j] = nums[i];
                    ++j;
                }
            }
            return j;

        }
    }
}
