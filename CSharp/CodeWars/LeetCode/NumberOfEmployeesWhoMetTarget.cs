public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        int count = 0;

        foreach (var i in hours)
            if (i >= target)
                count++;

        return count;
    }
}