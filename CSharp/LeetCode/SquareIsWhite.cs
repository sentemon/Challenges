// 1812. Determine Color of a Chessboard Square
public class Solution {
    public bool SquareIsWhite(string coordinates)
    {
        return (coordinates[0] - 'a' + coordinates[1] - '0') % 2 == 0;
    }
}