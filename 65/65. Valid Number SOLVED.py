class Solution(object):
    def isNumber(self, s):
        """
        :type s: str
        :rtype: bool
        """
        #regex
        pattern = r'^[+-]?(\.\d+|\d+\.\d*|\d+)([eE][+-]?\d+)?$'
    
        # Use match method to check if s matches the regex
        return bool(re.match(pattern, s.strip()))
