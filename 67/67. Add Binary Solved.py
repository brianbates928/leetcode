class Solution(object):
    def addBinary(self, a, b):
        """
        :type a: str
        :type b: str
        :rtype: str
        """
        # The int() function converts the binary to int
        # The bin() function converts the sum back to a binary string.
        # The binary string returned by bin() starts with '0b', so remove the prefix with [2:]
        return bin(int(a, 2) + int(b, 2))[2:]
