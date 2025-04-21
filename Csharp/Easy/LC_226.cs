using Csharp.LC.Classes;
namespace Csharp.Easy
{
    internal class InvertBinaryTree_226
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return root;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (node != null)
                {
                    TreeNode left = node.left;
                    TreeNode right = node.right;

                    node.left = right;
                    node.right = left;

                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }
            return root;
        }
    }


}
