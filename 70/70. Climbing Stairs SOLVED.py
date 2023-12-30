class Solution(object):
    def climbStairs(self, n):
        """
        :type n: int
        :rtype: int
        """
        # If there is only one step, there is only one way to climb it
        if n == 1:
            return 1
        # If there are two steps, there are two ways to climb it
        if n == 2:
            return 2
        # Initialize a list dp of size (n + 1) with all elements as 0
        dp = [0] * (n + 1)
        # There is one way to climb one step
        dp[1] = 1
        # There are two ways to climb two steps
        dp[2] = 2
        # For each step from 3 to n
        for i in range(3, n + 1):
            # The number of ways to climb it is the sum of the number of ways to climb the previous two steps
            dp[i] = dp[i - 1] + dp[i - 2]
        # Return the number of distinct ways to climb n steps
        return dp[n]
