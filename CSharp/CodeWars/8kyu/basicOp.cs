namespace Solution
{
  public static class Program
  {
    public static double basicOp(char operation, double value1, double value2)
    {
      switch (operation)
      {
        case '+':
            return value1 + value2;
        case '-':
            return value1 - value2;
        case '*':
            return value1 * value2;
        case '/':
            if (value2 != 0)
                return value1 / value2;
            else
                return -1;
        default:
          return -1;
      }
    }
  }
}