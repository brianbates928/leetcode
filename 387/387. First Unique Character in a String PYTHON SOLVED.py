class Solution(object):
    def firstUniqChar(self, s):
        """
        :type s: str
        :rtype: int
        """
        counts = {}
        for c in s:
            if c in counts:
                counts[c] += 1
            else:
                counts[c] = 1

        for i in range(len(s)):
            if counts[s[i]] == 1:
                return i

        return -1
