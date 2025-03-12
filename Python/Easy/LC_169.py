def majorityElement(nums) -> int:
    candidate, count = nums[0], 1
    for i in range(1, len(nums), 1):
        if nums[i] == candidate:
            count += 1
        else:
            count -= 1

        if count == 0 and i + 1 < len(nums):
            candidate = nums[i + 1]
    return candidate
ar = [2, 2, 1, 1, 1, 2, 2, 3, 3, 2, 2, 2, 4, 2, 4]
print(majorityElement(ar))

"""
moore's voting algorithm
a majority element is the element in the array that appears more than floor(n/2) times.
here are some simulation  

array: [2, 2, 1, 1, 2, 2]
count: [1, 2, 1, 0, 1, 2]
mj_em: [2, 2, 2, 2, 2, 2]

array: [2, 2, 1, 1, 1, 2, 2]
count: [1, 2, 1, 0, 1, 0, 1]
mj_em: [2, 2, 2, 1, 1, 2, 2]

array: [2, 2, 1, 1, 1, 2, 2, 3, 3, 2, 2, 2, 4, 2, 4]
count: [1, 2, 1, 0, 1, 0, 1, 0, 1, 0, 1, 2, 1, 2, 1]
mj_em: [2, 2, 2, 1, 1, 2, 2, 3, 3, 2, 2, 2, 2, 2, 2]

we will see in the above simulations that, as the majority element appears
more than floor(n/2) times other elements can not cancel it by decreasing 
the counter. 
"""
