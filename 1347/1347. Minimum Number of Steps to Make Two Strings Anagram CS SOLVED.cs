public class Solution {
    public int MinSteps(string s, string t) {
        int[] sCount = new int[26];
        int[] tCount = new int[26];
        int steps = 0;

        for (int i = 0; i < s.Length; i++) {
            // Increment the count of the current character 
            // Subtract 'a' to convert the character to its corresponding index in the alphabet
            sCount[s[i] - 'a']++;
            tCount[t[i] - 'a']++;
        }

        for (int i = 0; i < 26; i++) {
        // If the count of a character in t is less than in s
            if (tCount[i] < sCount[i]) {
                // Add the difference in counts to steps
                steps += sCount[i] - tCount[i];
            }
        }

        return steps;
    }
}
