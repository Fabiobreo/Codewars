using System;
​
public static class Kata
{
  public static int GetRealFloor(int n)
  {
      if (n <= 0) return n;
      if (n < 13) return n - 1;
      return n - 2;
  }
}