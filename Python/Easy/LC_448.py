from typing import List
def findDisappearedNumbers(nums: List[int]) -> List[int]:
    i = 0
    n = len(nums)
    missing = []

    while i < n:
        j = nums[i] - 1 # j is the index where nums[i] should be placed if nums[i] is sorted
        if nums[i] != nums[j]: # if nums[i] is not present in j index then swap
            nums[i], nums[j] = nums[j], nums[i]
        else:
            i += 1

    for i in range(n):
        if nums[i] != i + 1:
            missing.append(i + 1)
    return missing

nums = [4,3,2,7,8,2,3,1]
missing = findDisappearedNumbers(nums)
print(missing)