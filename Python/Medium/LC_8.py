def myAtoi(s: str) -> int:
    num = s.strip()
    is_negative = False
    if '-+' in num or '+-' in num or len(num) == 0:
        return 0
    if num[0] == '-':
        num = num[1:]
        is_negative = True
    if len(num) > 0 and num[0] == '+':
        num = num[1:]
    if len(num) > 0 and num[0].isdigit():
        ind = 0
        while ind < len(num):
            if not num[ind].isdigit():
                break
            ind += 1
        num = num[0:ind]

        result = int(num) if not is_negative else -1 * int(num)
        if result < -(1<<31):
            result = -(1<<31)
        if result > (1<<31) - 1:
            result = (1<<31) - 1
        return result
    return 0


res = myAtoi('-+23')
print(res)