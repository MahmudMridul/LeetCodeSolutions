using Csharp.LC.Classes;

namespace Csharp.Patterns.LC00113
{
    public class Solution
    {
        private IList<IList<int>> paths = new List<IList<int>>();

        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {    
            IList<int> path = new List<int>();
            PreOrder(root, 0, targetSum, path);
            return paths;
        }

        private void PreOrder(TreeNode node, int sum, int targetSum, IList<int> path)
        {
            if (node is null) return;

            path.Add(node.val);
            sum += node.val;

            if (node.left is null && node.right is null && sum == targetSum)
            {
                paths.Add(path.ToList());
            }
            PreOrder(node.left, sum, targetSum, path);
            PreOrder(node.right, sum, targetSum, path);
            path.RemoveAt(path.Count - 1);
        }
    }
}
