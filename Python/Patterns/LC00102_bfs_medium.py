from collections import deque
from typing import List

def levelOrder(root) -> List[List[int]]:
    if not root:
        return []

    result = []
    queue = deque([root])

    while queue:
        # before starting any operation inside the while loop
        # that means at this point
        # numbers of nodes currently in the queue represents a level
        level_size = len(queue)
        curr_level = []
        for _ in range(level_size):
            node = queue.popleft()
            curr_level.append(node.val)

            if node.left:
                queue.append(node.left)
            if node.right:
                queue.append(node.right)
        result.append(curr_level)
    return result

class TreeNode:
    def __init__(self, val = 0, left = None, right = None):
        self.val = val
        self.left = left
        self.right = right


root = TreeNode(val=3)
root.left = TreeNode(val=9)
root.right = TreeNode(val=20)
root.right.left = TreeNode(val=15)
root.right.right = TreeNode(val=7)

res = levelOrder(root)
print(res)
