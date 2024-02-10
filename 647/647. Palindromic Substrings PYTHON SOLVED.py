class Solution(object):
    def countSubstrings(self, s):
        """
        :type s: str
        :rtype: int
        """
        n = len(s)
        dp = [[False]*n for _ in range(n)]
        count = 0

        for length in range(1, n+1):  # Changed 'len' to 'length'
            for i in range(n - length + 1):
                j = i + length - 1
                if s[i] == s[j]:
                    dp[i][j] = length < 3 or dp[i+1][j-1]
                if dp[i][j]:
                    count += 1
        return count
