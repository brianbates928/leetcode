class Solution(object):
    def numberOfBeams(self, bank):
        """
        :type bank: List[str]
        :rtype: int
        """
        # Initialize the total number of beams and the count of devices in the previous row
        ans = temp = 0

        # Iterate over each row in the bank
        for s in bank:
            # Count the number of devices in the current row
            n = s.count('1')

            # If there are devices in the current row
            if n:
                ans += temp * n

                # Update the count of devices in the previous row
                temp = n

        # Return the total number of beams
        return ans
