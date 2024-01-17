class Solution(object):
    def myAtoi(self, s):
        """
        :type s: str
        :rtype: int
        """
        s = s.lstrip()  # Ignore leading whitespace
        if not s:
            return 0

        # Check for optional sign
        if s[0] == '-':
            sign = -1
            s = s[1:]
        elif s[0] == '+':
            sign = 1
            s = s[1:]
        else:
            sign = 1

        # Read in next the characters until the next non-digit character
        i = 0
        while i < len(s) and s[i].isdigit():
            i += 1
        num = s[:i]

        # Convert these digits into an integer
        if not num:
            return 0
        num = sign * int(num)

        # Clamp the number to the 32-bit signed integer range
        num = max(min(num, 2**31 - 1), -2**31)

        return num  # Return the integer as the final result
