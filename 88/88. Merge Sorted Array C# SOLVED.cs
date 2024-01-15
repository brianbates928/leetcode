public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // Initialize three pointers:
        // p1 points to the end of the meaningful part of nums1
        // p2 points to the end of nums2
        // p points to the end of nums1 (which includes the extra space for merging)
        int p1 = m - 1;
        int p2 = n - 1;
        int p = m + n - 1;

        while ((p1 >= 0) && (p2 >= 0)) {
            if (nums1[p1] > nums2[p2]) {
                // Place the larger element at the current position pointed by p in nums1
                nums1[p] = nums1[p1];
                p1--;
            } else {
                nums1[p] = nums2[p2];
                p2--;
            }
            p--;
        }

        // Nums2 is larger or equal due to constraits so move rest into nums1
        while (p2 >= 0) {
            nums1[p] = nums2[p2];
            p2--;
            p--;
        }
    }
}
