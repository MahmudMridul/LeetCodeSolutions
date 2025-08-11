using Csharp.LC.Classes;

namespace Csharp.Patterns.LC00112
{
    public class Solution
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            return PreOrder(root, 0, targetSum);
        }

        public bool PreOrder(TreeNode node, int sum, int target)
        {
            if (node is null) return false;
            sum += node.val;

            if (node.left is null && node.right is null && sum == target) return true;
            return PreOrder(node.left, sum, target) || PreOrder(node.right, sum, target);
        }
    }
}
