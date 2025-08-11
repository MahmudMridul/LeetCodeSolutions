using Csharp.LC.Classes;

namespace Csharp.Patterns.LC00107
{
    public class Solution
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if (root is null) return new List<IList<int>>();

            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<IList<int>> result = new List<IList<int>>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                int levelSize = queue.Count();
                List<int> level = new List<int>();

                for (int i = 0; i < levelSize; ++i)
                {
                    TreeNode node = queue.Dequeue();
                    level.Add(node.val);

                    if (node.left is not null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right is not null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                result.Insert(0, level);
            }
            return result;
        }
    }
}
