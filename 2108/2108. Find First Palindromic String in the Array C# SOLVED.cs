public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach (string word in words) {
            if (isPalindrome(word)){
                return word;
            }
        }
        return "";
    }


    public bool isPalindrome(string word) {
        int start = 0;
        int end = word.Length -1;
        while (start < end){
            if (word[start] != word[end]){
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}
