from typing import List

'''
def productExceptSelf(nums: List[int]) -> List[int]:
    size = len(nums)
    left_prod, right_prod, res = [1] * size, [1] * size, [1] * size
    left, right = 1, 1

    for i in range(1, size):
        left_prod[i] = left * nums[i - 1]
        left = left_prod[i]

    for i in range(size - 2, -1, -1):
        right_prod[i] = right * nums[i + 1]
        right = right_prod[i]

    for i in range(size):
        res[i] = left_prod[i] * right_prod[i]
        
    return res

'''

def productExceptSelf(nums: List[int]) -> List[int]:
    size = len(nums)
    res = [1] * size
    left, right = 1, 1

    for i in range(1, size):
        res[i] = left * nums[i - 1]
        left = res[i]

    for i in range(size - 2, -1, -1):
        prod = right * nums[i + 1]
        res[i] *= prod
        right = prod

    return res

a = [2, 3, 4, 5]
b = [-1, 1, 0, -3, 3]
productExceptSelf(a)
productExceptSelf(b)

"""
nums             2  3  4  5
lp               1  2  6  24
rp               60 20 5  1
res = lp * rp    60 40 30 24
"""