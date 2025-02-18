def inorder_traversal(node, result=[]):
    if node:
        inorder_traversal(node.left, result)
        result.append(node.value)
        inorder_traversal(node.right, result)
    return result

def preorder_traversal(node, result=[]):
    if node:
        result.append(node.value)
        preorder_traversal(node.left, result)
        preorder_traversal(node.right, result)
    return result

def postorder_traversal(node, result=[]):
    if node:
        postorder_traversal(node.left, result)
        postorder_traversal(node.right, result)
        result.append(node.value)
    return result