class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        if not s:
            return 0
        unique = set()
        left, right = 0, 1
        max_len = 1
        unique.add(s[0])

        while right < len(s):
            if s[right] not in unique:
                unique.add(s[right])
                max_len = max(max_len, right - left + 1)
                right += 1
            else:
                unique.remove(s[left])
                left += 1
        return max_len

if __name__ == '__main__':
    s = Solution()
    print(s.lengthOfLongestSubstring(""))


