class Solution(object):
    def convert(self, s, numRows):
        """
        :type s: str
        :type numRows: int
        :rtype: str
        """
        if numRows == 1 or numRows >= len(s):
            return s

        # Create an array of strings for each row
        arr = [''] * numRows
        index, step = 0, 1

        # Iterate through the string
        for char in s:
            arr[index] += char
            if index == 0:
                step = 1
            elif index == numRows - 1:
                step = -1
            index += step

        # Join all the strings in the array
        return ''.join(arr)
