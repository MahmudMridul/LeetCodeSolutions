from typing import List


def missingNumber(nums: List[int]) -> int:
    n = len(nums)
    expected_sum = (n * (n + 1)) // 2
    total = sum(nums)
    return expected_sum - total

nums = [0,1,3]
result = missingNumber(nums)
print(result)