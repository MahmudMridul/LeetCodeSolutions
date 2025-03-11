def climbStairs(n: int) -> int:
        if n == 1 or n == 2 or n == 3: return n
        arr = [0, 1, 2, 3]
        l, r, c = 2, 3, 4
        total = arr[l] + arr[r]
        while c <= 45:
            arr.append(total)
            c += 1
            l += 1
            r += 1
            total = arr[l] + arr[r]
        return arr[n]



v = climbStairs(10)
print(v)
