from typing import Optional


class ListNode:
    def __init__(self, val = 0, next = None):
        self.val = val
        self.next = next

class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        if list1 is None:
            return list2

        if list2 is None:
            return list1

        head = ListNode()
        pointer = head

        if list1.val < list2.val:
            head.val = list1.val
            list1 = list1.next
        else:
            head.val = list2.val
            list2  = list2.next

        while list1 and list2:
            if list1.val < list2.val:
                node = ListNode(val = list1.val)
                pointer.next = node
                list1 = list1.next
            else:
                node = ListNode(val = list2.val)
                pointer.next = node
                list2 = list2.next
            pointer = pointer.next

        if list1 or list2:
            pointer.next = list1 if list1 else list2

        return head