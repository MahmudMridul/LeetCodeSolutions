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

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int v = 0, TreeNode l = null, TreeNode r = null)
        {
            val = v; left = l; right = r;
        }
    }
}
