// 350. Intersection of Two Arrays II
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);

        int[] identicalElements = new int[Math.Min(nums1.Length, nums2.Length)]; 
        int i = 0, j = 0, t = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] < nums2[j])
                i++;
            else if (nums1[i] > nums2[j])
                j++;
            else
            {
                identicalElements[t++] = nums1[i++];
                j++;
            }
        }
        return identicalElements.Take(t).ToArray();
    }
}