def isAnagram(s: str, t: str) -> bool:
    for c in s:
        if c not in t:
            return False
    return True


isAnagram("rat", "car")