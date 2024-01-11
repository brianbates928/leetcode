public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || numRows >= s.Length)
            return s;

        StringBuilder[] sb = new StringBuilder[numRows];
        for (int i = 0; i < sb.Length; i++)
            sb[i] = new StringBuilder();

        int index = 0;
        int step = 1;

        foreach (char c in s) {
            sb[index].Append(c);
            if (index == 0)
                step = 1;
            else if (index == numRows - 1)
                step = -1;
            index += step;
        }

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < sb.Length; i++)
            result.Append(sb[i]);

        return result.ToString();
    }
}
