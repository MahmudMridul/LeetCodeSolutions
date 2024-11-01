namespace Csharp.Easy
{
    internal class MaxDepthBinaryTree_104
    {
        public int MaxDepth(TreeNode root)
        {
            int depth = postOrder(root, 0);
            return depth;
        }

        private int postOrder(TreeNode node, int depth)
        {
            if (node == null) return depth;
            int leftDepth = postOrder(node.left, depth + 1);
            int rightDepth = postOrder(node.right, depth + 1);
            return Math.Max(leftDepth, rightDepth);
        }
    }
}
