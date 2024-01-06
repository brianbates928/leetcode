public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        // If the array is empty, return an empty string
        if (strs.Length == 0) return "";
        
        // Initialize the prefix as the first string 
        string prefix = strs[0];
        
        // Iterate over each string in the array 
        for (int i = 1; i < strs.Length; i++) {
            // While the current string does not start with the prefix
            while (strs[i].IndexOf(prefix) != 0) {
                // Shorten the prefix by one character from the end
                // This finds the common prefix between strings 
                prefix = prefix.Substring(0, prefix.Length - 1);
                
                // If the prefix is empty, return an empty string
                if (string.IsNullOrEmpty(prefix)) return "";
            }
        }
        
        // Return the longest common prefix
        return prefix;
    }
}
