public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits)) return new List<string>();
        
        var phone = new Dictionary<char, string> {
            {'2', "abc"}, {'3', "def"}, {'4', "ghi"}, {'5', "jkl"},
            {'6', "mno"}, {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"}
        };
        
        var result = new List<string> {""};
        
        foreach (var digit in digits) {
            var temp = new List<string>();
            foreach (var res in result) {
                foreach (var ch in phone[digit]) {
                    temp.Add(res + ch);
                }
            }
            result = temp;
        }
        
        return result;
    }
}
