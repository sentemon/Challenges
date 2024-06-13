// 2037. Minimum Number of Moves to Seat Everyone
public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        int count = 0;
        
        Array.Sort(seats);
        Array.Sort(students);

        for (int i = 0; i < seats.Length; i++)
        {
            count += Math.Abs(seats[i] - students[i]);
        }

        return count;
    }
}