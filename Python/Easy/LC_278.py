v = [False, False, False, False, False, False, True, True, True, True]
def isBadVersion(i):
    return v[i]

def firstBadVersion(n: int) -> int:
    low, high = 1, n
    while low < high:
        mid = (low + high) // 2
        if isBadVersion(mid):
            high = mid
        else:
            low = mid + 1
    return low

firstBadVersion(10)
