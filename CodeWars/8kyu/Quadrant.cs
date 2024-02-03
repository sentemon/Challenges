using System;

public static class Kata
{
  public static int Quadrant(int x, int y)
  {
    if (x >= 0 && y >= 0)
      return 1;
    else if (x <= 0 && y >= 0)
      return 2;
    else if (x <= 0 && y <= 0)
      return 3;
    else
      return 4;
  }
}