from collections import deque
from typing import List

def levelOrderBottom(root) -> List[List[int]]:
    if root is None:
        return []

    queue = deque([root])
    result = []

    while queue:
        level_size = len(queue)
        curr_level = []

        for _ in range(level_size):
            node = queue.popleft()
            curr_level.append(node.val)

            if node.left:
                queue.append(node.left)
            if node.right:
                queue.append(node.right)
        result.insert(0, curr_level)
    return result