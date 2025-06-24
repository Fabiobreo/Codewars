using System;
​
public class Kata
{
  public static bool IsSquare(int n)
  {
      for (int i = 0; i * i <= n; ++i)
      {
          if (i * i == n) return true;
      }
      return false;
  }
}