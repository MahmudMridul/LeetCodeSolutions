from typing import List

def findDuplicate(nums: List[int]) -> int:
    fast = slow = nums[0]
    while True:
        slow = nums[slow]
        fast = nums[nums[fast]]
        if slow == fast:
            break
    slow = nums[0]
    while slow != fast:
        slow = nums[slow]
        fast = nums[fast]
    return slow

findDuplicate([1, 2, 3, 3, 4])

'''
val 1 3 4 2 2
ind 0 1 2 3 4

for any index i we treat nums[i] as pointing to the index nums[i]
if nums[3] = 5, then from index 3 we jump to index 5

linked list with index
0 --> 1 --> 3 --> 2 --> 4 --> 2 --> 4
see how index 2 and 4 are repeating. that means this is the cycle
'''