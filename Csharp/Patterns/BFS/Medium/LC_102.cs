
using Csharp.LC.Classes;

namespace Csharp.Patterns.BFS.Medium
{
    public class LC_102
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null) return new List<IList<int>>();

            IList<IList<int>> result = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
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
                result.Add(level);
            }
            return result;
        }
    }
}
