public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        List<int> selfDiv = new List<int>();

        for (int i = left; i <= right; i++)
        {
            int num = i;
            bool isSelfDividing = true;

            while (num > 0)
            {
                int digit = num % 10;
                if (digit == 0 || i % digit != 0)
                {
                    isSelfDividing = false;
                    break;
                }

                num /= 10;
            }

            if (isSelfDividing)
                selfDiv.Add(i);
        }

        return selfDiv;
    }
}