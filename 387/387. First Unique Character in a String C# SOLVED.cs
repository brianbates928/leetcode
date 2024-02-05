public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> counts = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            if (counts.ContainsKey(s[i])) {
                counts[s[i]]++;
            } else {
                counts[s[i]] = 1;
            }
        }

        for (int i = 0; i < s.Length; i++) {
            if (counts[s[i]] == 1) {
                return i;
            }
        }

        return -1;
    }
}
