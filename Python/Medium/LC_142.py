def detectCycle(head):
    fast = slow = head
    while fast and fast.next:
        slow = slow.next
        fast = fast.next.next
        if slow == fast:
            slow = head
            while slow != fast:
                slow = slow.next
                fast = fast.next
            return slow
    return None

'''
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



