from collections import Counter

def canConstruct(ransomNote: str, magazine: str) -> bool:
    magazine_counter = Counter(magazine)
    note_counter = Counter(ransomNote)
    for key in note_counter:
        count = magazine_counter.get(key)
        if count is None or count < note_counter[key]:
            return False
    return True

can = canConstruct("aa", "ab")
print(can)