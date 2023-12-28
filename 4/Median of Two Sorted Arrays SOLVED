class Solution:
    def findMedianSortedArrays(self, nums1, nums2):
        """
        :type nums1: List[int]
        :type nums2: List[int]
        :rtype: float
        """
        n, m = len(nums1), len(nums2)
        i = j = count = 0
        prev_num = curr_num = None

        while count <= (n + m) // 2:
            if i < n and (j >= m or nums1[i] < nums2[j]):
                prev_num = curr_num
                curr_num = nums1[i]
                i += 1
            else:
                prev_num = curr_num
                curr_num = nums2[j]
                j += 1
            count += 1

        if (n + m) & 1 == 0:  # Bitwise operation to check if total length is even
            return (prev_num + curr_num) / 2.0
        return curr_num
