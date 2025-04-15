def reverseList(head):
    prev, curr, nxt = None, head, None
    while curr is not None:
        nxt = curr.next
        curr.next = prev
        prev = curr
        curr = nxt
    return prev