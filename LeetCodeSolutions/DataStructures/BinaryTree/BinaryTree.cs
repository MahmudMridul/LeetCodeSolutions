
namespace LeetCodeSolutions.DataStructures.BinaryTree
{
    public class BinaryTree
    {
        Node? root;

        public BinaryTree(int[] values)
        {
            CreateTreeFromArray(values);
        }

        private void CreateTreeFromArray(int[] values)
        {
            root = new Node(values[0]);
            int index = 1;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (index < values.Length)
            {
                Node node = queue.Dequeue();
                Node? left = index < values.Length ? new Node(values[index++]) : null;
                Node? right = index < values.Length ? new Node(values[index++]) : null;

                node.left = left;
                node.right = right;

                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }            
        }

        public void BfsTraversal()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                Node node = queue.Dequeue();
                if (node != null)
                {
                    Console.WriteLine(node.value);

                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }
        }
    }

    public class Node
    {
        public int value;
        public Node? left;
        public Node? right;

        public Node(int val)
        {
            value = val;
        }
    }
}
