"""
Inorder traversal of a BST gives nodes in ascending order
For finding kth small element: inorder traversal, stop at k
Successor = smallest value larger than current
Predecessor = largest value smaller than current
Successor is leftmost node in right subtree
Predecessor is rightmost node in left subtree
Can construct unique BST from preorder + inorder
If two nodes, x and y, are on different subtrees of a node z (one in the left portion and one in the right portion),
then x and y have z as the lowest common ancestor.
"""

class Node:
    def __init__(self, val = 0, left = None, right = None):
        self.value = val
        self.left = left
        self.right = right

class BinarySearchTree:
    def __init__(self):
        self.root = None

    @staticmethod
    def find_min(node):
        current = node
        while current.left:
            current = current.left
        return current

    @staticmethod
    def find_max(node):
        current = node
        while current.right:
            current = current.right
        return current

    def find_height(self, node):
        if node is None:
            return -1 # to ensure leaf node gets height 0 --> left node returns max(-1, -1) + 1 = 0
        return max(self.find_height(node.left), self.find_height(node.right)) + 1

    def insert(self, value):
        if not self.root:
            self.root = Node(value)
            return
        self.__insert(self.root, value)

    def __insert(self, node, value):
        if value < node.value:
            if node.left is None:
                node.left = Node(value)
            else:
                self.__insert(node.left, value)
        else:
            if node.right is None:
                node.right = Node(value)
            else:
                self.__insert(node.right, value)

    def delete(self, value):
        self.root = self.__delete(self.root, value)

    def __delete(self, node, value):
        if node is None:
            return None

        if value < node.value:
            node.left = self.__delete(node.left, value)
        elif value > node.value:
            node.right = self.__delete(node.right, value)
        else:
            # node with 0 or 1 child
            if node.left is None:
                return node.right
            elif node.right is None:
                return node.left

            # node with 2 children
            temp = BinarySearchTree.find_min(node.right)
            node.value = temp.value
            node.right = self.__delete(node.right, temp.value)
        return node

    def search(self, value):
        return self._search(self.root, value)

    def _search(self, node, value):
        if node is None or node.value == value:
            return node

        if value < node.value:
            return self._search(node.left, value)
        return self._search(node.right, value)

