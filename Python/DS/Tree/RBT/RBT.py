class Node:
    def __init__(self, key, color="RED"):
        self.key = key
        self.left = None
        self.right = None
        self.parent = None
        self.color = color  # "RED" or "BLACK"


class RedBlackTree:
    def __init__(self):
        self.NIL = Node(None, "BLACK")  # sentinel node
        self.root = self.NIL

    def insert(self, key):
        new_node = Node(key)
        new_node.left = self.NIL
        new_node.right = self.NIL

        # Perform standard BST insert
        parent_node = None
        current_node = self.root

        while current_node != self.NIL:
            parent_node = current_node
            if new_node.key < current_node.key:
                current_node = current_node.left
            else:
                current_node = current_node.right

        new_node.parent = parent_node

        if parent_node is None:
            self.root = new_node  # Tree was empty
        elif new_node.key < parent_node.key:
            parent_node.left = new_node
        else:
            parent_node.right = new_node

        # If new node is root, just color it black and return
        if new_node.parent is None:
            new_node.color = "BLACK"
            return

        # If grandparent is None, return
        if new_node.parent.parent is None:
            return

        self.__fix_insert(new_node)

    def __fix_insert(self, inserted_node):
        while inserted_node != self.root and inserted_node.parent.color == "RED":
            # If parent is left child of grandparent
            if inserted_node.parent == inserted_node.parent.parent.left:
                uncle_node = inserted_node.parent.parent.right

                # Case 1: Uncle is red - recolor
                if uncle_node.color == "RED":
                    inserted_node.parent.color = "BLACK"
                    uncle_node.color = "BLACK"
                    inserted_node.parent.parent.color = "RED"
                    inserted_node = inserted_node.parent.parent
                else:
                    # Case 2: inserted_node is right child - left rotation
                    if inserted_node == inserted_node.parent.right:
                        inserted_node = inserted_node.parent
                        self.__left_rotate(inserted_node)

                    # Case 3: inserted_node is left child - right rotation
                    inserted_node.parent.color = "BLACK"
                    inserted_node.parent.parent.color = "RED"
                    self.__right_rotate(inserted_node.parent.parent)
            else:
                # Same as above, but mirror image
                uncle_node = inserted_node.parent.parent.left

                # Case 1: Uncle is red - recolor
                if uncle_node.color == "RED":
                    inserted_node.parent.color = "BLACK"
                    uncle_node.color = "BLACK"
                    inserted_node.parent.parent.color = "RED"
                    inserted_node = inserted_node.parent.parent
                else:
                    # Case 2: inserted_node is left child - right rotation
                    if inserted_node == inserted_node.parent.left:
                        inserted_node = inserted_node.parent
                        self.__right_rotate(inserted_node)

                    # Case 3: inserted_node is right child - left rotation
                    inserted_node.parent.color = "BLACK"
                    inserted_node.parent.parent.color = "RED"
                    self.__left_rotate(inserted_node.parent.parent)

        # Ensure root is black
        self.root.color = "BLACK"

    def delete(self, key):
        node_to_delete = self.__search_node(key)

        if node_to_delete is None or node_to_delete == self.NIL:
            print(f"Key {key} not found in the tree")
            return False

        original_color = node_to_delete.color
        replacement_node = self.NIL

        # Case 1: Node to delete has at most one child
        if node_to_delete.left == self.NIL:
            replacement_node = node_to_delete.right
            self.__transplant(node_to_delete, node_to_delete.right)
        elif node_to_delete.right == self.NIL:
            replacement_node = node_to_delete.left
            self.__transplant(node_to_delete, node_to_delete.left)
        # Case 2: Node to delete has two children
        else:
            # Find successor (minimum in right subtree)
            successor = self.find_minimum(node_to_delete.right)
            original_color = successor.color
            replacement_node = successor.right

            # If successor is a direct child of node_to_delete
            if successor.parent == node_to_delete:
                # Ensure replacement_node.parent is set correctly
                if replacement_node != self.NIL:
                    replacement_node.parent = successor
            else:
                # Replace successor with its right child
                self.__transplant(successor, successor.right)
                # Connect successor to node_to_delete's right child
                successor.right = node_to_delete.right
                successor.right.parent = successor

            # Replace node_to_delete with successor
            self.__transplant(node_to_delete, successor)
            # Connect successor to node_to_delete's left child
            successor.left = node_to_delete.left
            successor.left.parent = successor
            successor.color = node_to_delete.color

        # If the original color was BLACK, we need to fix Red-Black properties
        if original_color == "BLACK":
            self.__fix_delete(replacement_node)

        return True

    def __fix_delete(self, current_node):
        while current_node != self.root and current_node.color == "BLACK":
            # Make sure current_node is not None and has a parent
            if current_node == self.NIL and current_node.parent is None:
                break

            if current_node == current_node.parent.left:
                sibling = current_node.parent.right

                # Case 1: Sibling is red
                if sibling.color == "RED":
                    sibling.color = "BLACK"
                    current_node.parent.color = "RED"
                    self.__left_rotate(current_node.parent)
                    sibling = current_node.parent.right

                # Case 2: Sibling's children are both black
                if (sibling.left == self.NIL or sibling.left.color == "BLACK") and \
                        (sibling.right == self.NIL or sibling.right.color == "BLACK"):
                    sibling.color = "RED"
                    current_node = current_node.parent
                else:
                    # Case 3: Sibling's right child is black
                    if sibling.right == self.NIL or sibling.right.color == "BLACK":
                        if sibling.left != self.NIL:
                            sibling.left.color = "BLACK"
                        sibling.color = "RED"
                        self.__right_rotate(sibling)
                        sibling = current_node.parent.right

                    # Case 4: Sibling's right child is red
                    sibling.color = current_node.parent.color
                    current_node.parent.color = "BLACK"
                    if sibling.right != self.NIL:
                        sibling.right.color = "BLACK"
                    self.__left_rotate(current_node.parent)
                    current_node = self.root
            else:
                # Mirror case for right child
                sibling = current_node.parent.left

                # Case 1: Sibling is red
                if sibling.color == "RED":
                    sibling.color = "BLACK"
                    current_node.parent.color = "RED"
                    self.__right_rotate(current_node.parent)
                    sibling = current_node.parent.left

                # Case 2: Sibling's children are both black
                if (sibling.right == self.NIL or sibling.right.color == "BLACK") and \
                        (sibling.left == self.NIL or sibling.left.color == "BLACK"):
                    sibling.color = "RED"
                    current_node = current_node.parent
                else:
                    # Case 3: Sibling's left child is black
                    if sibling.left == self.NIL or sibling.left.color == "BLACK":
                        if sibling.right != self.NIL:
                            sibling.right.color = "BLACK"
                        sibling.color = "RED"
                        self.__left_rotate(sibling)
                        sibling = current_node.parent.left

                    # Case 4: Sibling's left child is red
                    sibling.color = current_node.parent.color
                    current_node.parent.color = "BLACK"
                    if sibling.left != self.NIL:
                        sibling.left.color = "BLACK"
                    self.__right_rotate(current_node.parent)
                    current_node = self.root

        current_node.color = "BLACK"

    def __transplant(self, node_u, node_v):
        """Replace subtree rooted at node_u with subtree rooted at node_v"""
        if node_u.parent is None:
            self.root = node_v
        elif node_u == node_u.parent.left:
            node_u.parent.left = node_v
        else:
            node_u.parent.right = node_v

        # Set parent pointer of node_v
        if node_v is not None:  # This handles the case where node_v might be None
            node_v.parent = node_u.parent

    def find_minimum(self, node):
        current = node
        while current.left != self.NIL:
            current = current.left
        return current

    def find_maximum(self, node):
        current = node
        while current.right != self.NIL:
            current = current.right
        return current

    def __search_node(self, key):
        current = self.root
        while current != self.NIL:
            if key == current.key:
                return current
            if key < current.key:
                current = current.left
            else:
                current = current.right
        return None

    def __left_rotate(self, pivot_node):
        right_child = pivot_node.right
        pivot_node.right = right_child.left

        if right_child.left != self.NIL:
            right_child.left.parent = pivot_node

        right_child.parent = pivot_node.parent

        if pivot_node.parent is None:
            self.root = right_child
        elif pivot_node == pivot_node.parent.left:
            pivot_node.parent.left = right_child
        else:
            pivot_node.parent.right = right_child

        right_child.left = pivot_node
        pivot_node.parent = right_child

    def __right_rotate(self, pivot_node):
        left_child = pivot_node.left
        pivot_node.left = left_child.right

        if left_child.right != self.NIL:
            left_child.right.parent = pivot_node

        left_child.parent = pivot_node.parent

        if pivot_node.parent is None:
            self.root = left_child
        elif pivot_node == pivot_node.parent.right:
            pivot_node.parent.right = left_child
        else:
            pivot_node.parent.left = left_child

        left_child.right = pivot_node
        pivot_node.parent = left_child

    def search(self, key):
        node = self.__search_node(key)
        return node if node != self.NIL and node is not None else None

    def print_tree(self):
        if self.root == self.NIL:
            print("Tree is empty")
            return

        self.__print_helper(self.root, "", True)

    def __print_helper(self, current_node, indent, is_last_child):
        if current_node != self.NIL:
            print(indent, end="")
            if is_last_child:
                print("└──", end="")
                new_indent = indent + "    "
            else:
                print("├──", end="")
                new_indent = indent + "│   "

            print(f"{current_node.key}({current_node.color})")

            self.__print_helper(current_node.left, new_indent, False)
            self.__print_helper(current_node.right, new_indent, True)