class Solution(object):
    def maxSumAfterPartitioning(self, arr, k):
        """
        :type arr: List[int]
        :type k: int
        :rtype: int
        """
        n = len(arr)
        dp = [0] * n
        for i in range(n):
            max_val = arr[i]
            for j in range(1, k+1):
                if i - j + 1 < 0:
                    break
                max_val = max(max_val, arr[i - j + 1])
                dp[i] = max(dp[i], (dp[i - j] if i >= j else 0) + max_val * j)
        return dp[n - 1]
