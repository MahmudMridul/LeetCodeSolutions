def isBalanced(self, root) -> bool:
    if root is None:
        return True
    left_height = self.find_height(root.left)
    right_height = self.find_height(root.right)
    return abs(left_height - right_height) <= 1 and self.isBalanced(root.left) and self.isBalanced(root.right)


def find_height(self, node):
    if node is None:
        return -1
    left_height = self.find_height(node.left)
    right_height = self.find_height(node.right)
    return max(left_height, right_height) + 1