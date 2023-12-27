class Solution(object):
    def kthFactor(self, n, k):
        """
        :type n: int
        :type k: int
        :rtype: int
        """
        factors = [1]
        for i in range(2, n // 2 + 1):
            if n % i == 0:
                factors.append(i)
        factors.append(n)
        if k-1 < len(factors):
            return factors[k-1]
        else:
            return -1
