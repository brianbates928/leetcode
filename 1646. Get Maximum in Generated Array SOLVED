class Solution(object):
    def getMaximumGenerated(self, n):
        if n<2:
            return n
        arr = [0, 1, 1]
        for i in range(3, n+1):
            temp = arr[i >> 1]
            if i & 1 == 0:
                arr.append(temp)
            else:
                arr.append(temp + arr[(i >> 1) + 1])
        return max(arr)
