from typing import List
paths = []

def pathSum(root, targetSum) -> List[List[int]]:
    pre_order(root, 0, targetSum, [])

def pre_order(node, sum, target_sum, path):
    if not node:
        return
    path.append(node.val)
    sum += node.val
    if not node.left and not node.right and sum == target_sum:
        paths.append(path[:])
    pre_order(node.left, sum, target_sum, path)
    pre_order(node.right, sum, target_sum, path)
    path.pop()

class TreeNode:
    def __init__(self, val = 0, left = None, right = None):
        self.val = val
        self.left = left
        self.right = right


root = TreeNode(val = 5)
root.left = TreeNode(val=4)
root.right = TreeNode(val=8)

root.left.left = TreeNode(val=11)
root.left.left.left = TreeNode(val=7)
root.left.left.right = TreeNode(val=2)

root.right.left = TreeNode(val=13)
root.right.right = TreeNode(val=4)
root.right.right.left = TreeNode(val=5)
root.right.right.right = TreeNode(val=1)

pathSum(root, 22)
print(paths)