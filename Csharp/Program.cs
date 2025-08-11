using Csharp.Algorithms.Arrays;
using Csharp.Easy;
using Csharp.Helpers;
using Csharp.LC.Classes;
using Csharp.Medium;
using Csharp.Patterns.DFS.Medium;

namespace Csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TreeNode tree = MakeTree();
            int targetSum = 22;
            new LC00113_dfs_medium().PathSum(tree, targetSum);
        }

        private static TreeNode MakeTree()
        {
            TreeNode root = new TreeNode(5);

            root.left = new TreeNode(4);
            root.right = new TreeNode(8);

            root.left.left = new TreeNode(11);

            root.left.left.left = new TreeNode(7);
            root.left.left.right = new TreeNode(7);

            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(4);

            root.right.right.right = new TreeNode(5);
            root.right.right.right = new TreeNode(1);
            return root;
        }
    }
}
