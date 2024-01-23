class Solution(object):
    def reverse(self, x):
        """
        :type x: int
        :rtype: int
        """
        # Determine the sign of x
        sign = [1,-1][x < 0]
        
        # Initialize reversed number to 0 and take absolute value of x
        rev, x = 0, abs(x)
        
        while x:
            # Quotient is assigned to x for next iteration
            # Remainder is added to rev after shifting its digits to the left
            x, mod = divmod(x, 10)
            rev = rev * 10 + mod
            
        # Apply the sign
        rev = sign * rev
        
        # Check if reversed number is within the 32-bit signed integer range
        return rev if -2**31 <= rev <= 2**31 - 1 else 0
