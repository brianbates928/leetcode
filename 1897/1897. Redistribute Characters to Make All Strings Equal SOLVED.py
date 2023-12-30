class Solution(object):
    def makeEqual(self, words):
        """
        :type words: List[str]
        :rtype: bool
        """
        # Initialize a counter to keep track of character frequencies
        counter = Counter()
        
        # Count the frequency of each character in a single pass
        for word in words:
            counter += Counter(word)
        
        # Check if each character can be evenly distributed among the words
        return all(count % len(words) == 0 for count in counter.values())
