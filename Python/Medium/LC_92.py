def reverseBetween(head, left, right):
    if left == right:
        return head

    curr, prev, i = head, None, 0
    while curr is not None and i < left - 1:
        prev = curr
        curr = curr.next
        i += 1

    last_node_first_part = prev
    # after reversing curr will become last node of the sub list
    last_node_sub_list = curr
    nxt = None

    i = 0
    while curr is not None and i < right - left + 1:
        nxt = curr.next
        curr.next = prev
        prev = curr
        curr = nxt
        i += 1

    if last_node_first_part is not None:
        last_node_first_part.next = prev
    else:
        head = prev

    last_node_sub_list.next = curr
    return head