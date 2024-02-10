class Solution(object):
    def countSubstrings(self, s):
        """
        :type s: str
        :rtype: int
        """
        n = len(s)
        dp = [[False]*n for _ in range(n)]
        count = 0

        for len in range(1, n+1):
            for i in range(n - len + 1):
                j = i + len - 1
                if s[i] == s[j]:
                    dp[i][j] = len < 3 or dp[i+1][j-1]
                if dp[i][j]:
                    count += 1
        return count
