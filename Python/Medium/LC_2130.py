def pairSum(head) -> int:
    list = []
    while head:
        list.append(head.val)
        head = head.next

    L, R, sum = 0, len(list) - 1, -1
    while L < R:
        sum = max(list[L] + list[R], sum)
        L += 1
        R -= 1
    return sum