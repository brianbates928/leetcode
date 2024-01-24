public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        // Start with empty string no open or closed
        Backtrack(result, "", 0, 0, n);
        return result;
    }

    private void Backtrack(List<string> result, string current, int open, int close, int max){
        if(current.Length == max * 2){
            //if at max return pairs
            result.Add(current);
            return;
        }
        // Can add more pairs
        if(open < max)
            Backtrack(result, current + "(", open + 1, close, max);
        // Need close for an already open
        if(close < open)
            Backtrack(result, current + ")", open, close + 1, max);
    }
}
