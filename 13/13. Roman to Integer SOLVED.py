class Solution(object):
    def romanToInt(self, s):
        """
        :type s: str
        :rtype: int
        """
        roman_to_int = {'I': 1, 'V': 5, 'X': 10, 'L': 50, 'C': 100, 'D': 500, 'M': 1000}
        prev_value = 0
        total = 0
        for c in s:
            curr_value = roman_to_int[c]
            total += curr_value
            # If the current numeral is larger, subtract twice the value of the previous numeral
            if curr_value > prev_value:
                total -= 2 * prev_value
            prev_value = curr_value
        return total
