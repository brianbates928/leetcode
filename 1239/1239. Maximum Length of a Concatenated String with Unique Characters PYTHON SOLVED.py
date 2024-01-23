class Solution(object):
    def maxLength(self, arr):
        """
        :type arr: List[str]
        :rtype: int
        """
        # Filter out the strings with duplicate characters.
        # If a string has duplicate characters, it cannot be part of the maximum length string with unique characters.
        arr = [a for a in arr if len(set(a)) == len(a)]
        
        # Initialize the result (maximum length of string with unique characters) to 0.
        self.res = 0
        
        # Start the depth-first search (DFS) from the first string in the array.
        self.dfs(arr, '', 0)
        
        # Return the maximum length found.
        return self.res
    
    def dfs(self, arr, path, idx):
        # Update the maximum length with the maximum of the current maximum length and the length of the current string.
        self.res = max(self.res, len(path))
        
        # Iterate over the strings in the array starting from the index 'idx'.
        for i in range(idx, len(arr)):
            # Check if the current string 'arr[i]' has any common character with the already formed string 'path'.
            # If not, it means we can add 'arr[i]' to 'path' to form a longer string with unique characters.
            if not set(path) & set(arr[i]):
                # So, we add 'arr[i]' to 'path' and continue the DFS with the next string.
                self.dfs(arr, path+arr[i], i+1)
