from typing import List

def subarraySum(nums: List[int], k: int) -> int:
    prefix_sum = 0
    check = { 0: 1 }
    count = 0
    for n in nums:
        prefix_sum += n
        if (prefix_sum - k) in check:
            count += check[prefix_sum - k]
        if prefix_sum in check:
            check[prefix_sum] += 1
        else:
            check[prefix_sum] = 1
    return count

ar = [1, 1, 1]
k = 2
ans = subarraySum(ar, k)
print(ans)