public class Solution {
    public int MyAtoi(string s) {
        s = s.TrimStart();  // Ignore leading whitespace
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }

        // Check for optional sign
        int sign;
        if (s[0] == '-') {
            sign = -1;
            s = s.Substring(1);
        } else if (s[0] == '+') {
            sign = 1;
            s = s.Substring(1);
        } else {
            sign = 1;
        }

        // Read in next the characters until the next non-digit character
        int i = 0;
        while (i < s.Length && char.IsDigit(s[i])) {
            i++;
        }
        string numStr = s.Substring(0, i);

        // Convert these digits into an integer
        if (string.IsNullOrEmpty(numStr)) {
            return 0;
        }
        long num;
        if (!long.TryParse(numStr, out num)) {
            return sign == 1 ? Int32.MaxValue : Int32.MinValue;
        }
        num *= sign;

        // Ensure the number is set to 32-bit signed integer range
        num = Math.Max(Math.Min(num, (long)Int32.MaxValue), (long)Int32.MinValue);

        return (int)num;  // Return the integer as the final result
    }
}
