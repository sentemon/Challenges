public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int j = 0; j < i; j++)
                leftSum += arr[j];

            for (int k = i + 1; k < arr.Length; k++)
                rightSum += arr[k];

            if (leftSum == rightSum)
                return i;
        }

        return -1;
    }
}