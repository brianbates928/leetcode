public class Solution {
    public string LongestPalindrome(string s) {
    // If the string is null or empty, return an empty string
    if (string.IsNullOrEmpty(s)) return "";
    
    int start = 0, end = 0;
    for (int i = 0; i < s.Length; i++) {
        // Find the length of the palindrome with odd length
        int len1 = ExpandAroundCenter(s, i, i);
        // Find the length of the palindrome with even length
        int len2 = ExpandAroundCenter(s, i, i + 1);
        // Get the maximum length
        int len = Math.Max(len1, len2);
        // If the length of the palindrome is greater than the current longest
        if (len > end - start) {
            // Update the start and end indices of the longest palindrome
            start = i - (len - 1) / 2;
            end = i + len / 2;
        }
    }
    // Return the longest palindrome
    return s.Substring(start, end - start + 1);
}

private int ExpandAroundCenter(string s, int left, int right) {
    // Expand around the center as long as the characters are the same
    while (left >= 0 && right < s.Length && s[left] == s[right]) {
        left--;
        right++;
    }
    // Return the length of the palindrome
    return right - left - 1;
}
}
