public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        var res = new List<int>();  
        // Edge case handling
        if (s == null || s.Length == 0 || words == null || words.Length == 0) return res;

        var len = words[0].Length;  // The length of each word

        var map = new Dictionary<string, int>();
        foreach (var w in words) {
            if (map.ContainsKey(w)) map[w]++;
            else map[w] = 1;
        }

        // Iterate over the string with a step of len (the length of each word)
        for (var i = 0; i < len; i++) {
            var start = i;  
            var count = 0;  
            var seen = new Dictionary<string, int>();  

            // Iterate over the string from the current starting index with a step of word len
            for (var j = i; j <= s.Length - len; j += len) {
                var str = s.Substring(j, len);  // The current word

                // If the current word already exists
                if (map.ContainsKey(str)) {
                    // Add the current word 
                    if (seen.ContainsKey(str)) seen[str]++;
                    else seen[str] = 1;

                    // If the current word is not overused, increase the count
                    if (seen[str] <= map[str]) count++;

                    // If all words are seen the correct number of times, add the starting index to the result list
                    while (count == words.Length) {
                        var temp = s.Substring(start, len);
                        if (seen[temp] <= map[temp]) count--;
                        seen[temp]--;
                        if (j - start == len * (words.Length - 1)) res.Add(start);
                        start += len;
                    }
                } else {
                    // If the current word does not exist in the map reset and move the start pointer to the next word
                    seen.Clear();
                    count = 0;
                    start = j + len;
                }
            }
        }

        return res;
    }
}
