def detectCycle(head):
    visited = set()
    node = head
    while node:
        if node in visited:
            return node
        else:
            visited.add(node)
        node = node.next
    return None

'''
def detectCycle(head):
    slow = fast = head
    while fast and fast.next:
        slow = slow.next
        fast = fast.next.next
        if slow == fast:
            visited = set()
            node = head
            while node:
                if node in visited:
                    return node
                else:
                    visited.add(node)
                node = node.next
    return None
'''



