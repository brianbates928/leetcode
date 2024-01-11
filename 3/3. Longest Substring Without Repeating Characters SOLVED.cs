public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        //HashSet to store the characters in the current substring
        HashSet<char> set = new HashSet<char>();
        
        // max length of the substring (ans), and two pointers for the current substring (i and j)
        int ans = 0, i = 0, j = 0;
        
        // Start a loop that continues until reach the end of the string
        while (i < n && j < n) {
            // If the character at position j is not in the set, add it to the set,
            // increment j, and update the maximum length of the substring
            if (!set.Contains(s[j])){
                set.Add(s[j++]);
                //ans keeps track of longest found 
                ans = Math.Max(ans, j - i);
            }
            // If the character at position j is in the set, 
            // clear the set and start over count with substring after repeated char
            else {
                set.Remove(s[i++]);
            }
        }
        return ans;
    }
}
