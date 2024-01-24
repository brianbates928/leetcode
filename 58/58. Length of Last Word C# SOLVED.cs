public class Solution {
    public int LengthOfLastWord(string s) {
        int length = s.Length-1;
        int word = 0;
        while(length != -1 && s[length] == ' '){
            length--;
            }
        while(length != -1 && s[length]!= ' '){
            word++;
            length--;
        }
        return word;
    }
}
