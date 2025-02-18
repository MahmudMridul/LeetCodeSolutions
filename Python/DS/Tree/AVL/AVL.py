"""
four cases of imbalance:
1.  left-left case
    balance > 1 and value < root.left.value
    solution: right rotation

2.  left-right case
    balance > 1 and value > root.left.value
    solution: left rotation on left child, right rotation on root

3.  right-right case
    balance < -1 and value > root.right.value
    solution: left rotation

4.  right-left case
    balance < -1 and value < root.right.value
    solution: right rotation on right child, left rotation on root
"""
class Node:
    def __init__(self, val):
        self.value = val
        self.left = None
        self.right = None
        self.height = 1

class AVL:
    def __init__(self):
        self.root = None

    @staticmethod
    def get_height(node):
        if not node:
            return 0
        return node.height

    def get_balance_factor(self, node):
        if not node:
            return 0
        return self.get_height(node.left) - self.get_height(node.right)

    def __update_height(self, node):
        if not node:
            return
        node.height = max(self.get_height(node.left), self.get_height(node.right)) + 1

    def __right_rotate(self, current_root):
        new_root = current_root.left
        orphaned_subtree = new_root.right

        # Perform rotation
        new_root.right = current_root
        current_root.left = orphaned_subtree

        # Update heights
        self.__update_height(current_root)
        self.__update_height(new_root)

        return new_root

    def __left_rotate(self, current_root):
        new_root = current_root.right
        orphaned_subtree = new_root.left

        # Perform rotation
        new_root.left = current_root
        current_root.right = orphaned_subtree

        # Update heights
        self.__update_height(current_root)
        self.__update_height(new_root)

        return new_root

    def insert(self, value):
        self.root = self.__insert_recursive(self.root, value)

    def __insert_recursive(self, node, value):
        if not node:
            return Node(value)

        if not node:
            return Node(value)

        if value < node.value:
            node.left = self.__insert_recursive(node.left, value)
        elif value > node.value:
            node.right = self.__insert_recursive(node.right, value)
        else:
            return node  # Duplicate values are not allowed

        self.__update_height(node)
        balance = self.get_balance_factor(node)

        # left-left Case
        if balance > 1 and value < node.left.value:
            return self.__right_rotate(node)

        # left-right Case
        if balance > 1 and value > node.left.value:
            node.left = self.__left_rotate(node.left)
            return self.__right_rotate(node)

        # right-right Case
        if balance < -1 and value > node.right.value:
            return self.__left_rotate(node)

        # right-left Case
        if balance < -1 and value < node.right.value:
            node.right = self.__right_rotate(node.right)
            return self.__left_rotate(node)

        return node