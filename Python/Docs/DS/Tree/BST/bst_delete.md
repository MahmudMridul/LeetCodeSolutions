There are three possible cases when deleting a node in a BST.

1. Deleting a leaf node.
2. Deleting a node with one child.
3. Deleting a node with two children.

### 1. Deleting a Leaf Node

Just delete the node and set its parent's corresponding pointer to null.

### 2. Delete a Node with One Child

Let's say we need to delete the node named `D`. Parent of `D` is named `P` and `D` has one child named `C`. For this operation we connect `C` to `P`. As a result `D` gets deleted.

### 3. Delete a Node with Two Children

Following process can be done with successor (smallest value in right sub tree) or predecessor (largest value in left sub tree).

```python
# When we find the node (value == node.value)
temp = BinarySearchTree.find_min(node.right)  # Find successor
node.value = temp.value                       # Copy successor's value
node.right = self.__delete(node.right, temp.value)  # Delete successor
```

Let's say we have this tree and want to delete node 8:

```
        8
      /  \
     4   10
    / \    \
   2   6    12
```

The process works like this:

#### A. Find the Successor:

- The successor is the smallest value in the right subtree
- In our case, `find_min(node.right)` finds 10

```
    8*        # Want to delete 8
   / \
  4   10 ←   # This is the successor (smallest in right subtree)
 / \    \
2   6    12
```

#### B. Copy Successor's Value:

- Copy 10 into the node we want to delete

```
    10        # 8 is replaced with 10
   / \
  4   10     # Original 10 is still here
 / \    \
2   6    12
```

#### C. Delete the Successor:

- Recursively delete the successor from the right subtree
- Since the successor is always the leftmost node, it will have at most one child

```
    10        # Final tree
   / \
  4   12
 / \
2   6
```

This method works because:

1. The successor is always greater than all nodes in the left subtree
2. The successor is always smaller than all remaining nodes in the right subtree
3. This preserves the BST property where left < node < right

It's like we're not really deleting the node, but rather:

1. Finding a valid replacement value (the successor)
2. Copying that value to the current node
3. Deleting the successor (which is easier because it has at most one child)

The reason we use the successor (smallest in right subtree) is to maintain the BST property. We could alternatively use the predecessor (largest in left subtree) and the logic would still work.
