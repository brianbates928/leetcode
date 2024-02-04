public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length) {
            return "";
        }

        int[] tFrequency = new int[128];
        foreach (char c in t) {
            tFrequency[c]++;
        }

        int required = t.Length;
        int left = 0, right = 0;
        int minLen = int.MaxValue;
        int start = 0; // to store the starting index of min window

        while (right < s.Length) {
            if (tFrequency[s[right]] > 0) {
                required--;
            }
            tFrequency[s[right]]--;

            while (required == 0) {
                if (right - left + 1 < minLen) {
                    minLen = right - left + 1;
                    start = left; // update the start index
                }

                tFrequency[s[left]]++;
                if (tFrequency[s[left]] > 0) {
                    required++;
                }
                left++;
            }
            right++;
        }

        return minLen == int.MaxValue ? "" : s.Substring(start, minLen);
    }
}
