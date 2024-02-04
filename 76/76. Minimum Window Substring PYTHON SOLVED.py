class Solution(object):
    def minWindow(self, s, t):
        """
        :type s: str
        :type t: str
        :rtype: str
        """
        if not s or not t:
            return ""

        tFrequency = [0] * 128
        for c in t:
            tFrequency[ord(c)] += 1

        required = len(t)
        left, right = 0, 0
        minLen = float('inf')
        minWindow = ""

        while right < len(s):
            if tFrequency[ord(s[right])] > 0:
                required -= 1
            tFrequency[ord(s[right])] -= 1

            while required == 0:
                if right - left + 1 < minLen:
                    minLen = right - left + 1
                    minWindow = s[left:right+1]

                tFrequency[ord(s[left])] += 1
                if tFrequency[ord(s[left])] > 0:
                    required += 1
                left += 1

            right += 1

        return minWindow if minLen != float('inf') else ""
