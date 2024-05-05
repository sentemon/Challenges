public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
        List<int> answer = new List<int>();
        int n = 0;
        int m = 0;

        for (int i = 0; i < nums1.Length; i++)
            if (nums2.Contains(nums1[i]))
                n++;
        answer.Add(n);

        for (int i = 0; i < nums2.Length; i++)
            if (nums1.Contains(nums2[i]))
                m++;
        answer.Add(m);
        
        return answer.ToArray();
    }
}