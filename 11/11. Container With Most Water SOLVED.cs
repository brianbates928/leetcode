public class Solution {
    public int MaxArea(int[] height) {
    int maxarea = 0, left = 0, right = height.Length - 1;
    while (left < right) {
        maxarea = Math.Max(maxarea, Math.Min(height[left], height[right]) * (right - left));
        if (height[left] < height[right])
            left++;
        else
            right--;
    }
    return maxarea;
}

}
