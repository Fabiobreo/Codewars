using System;
​
public static class Kata
{
  public static int Factorial(int n)
  {
      if (n < 0 || n > 12) throw new ArgumentOutOfRangeException();
      int fact = 1;
      for (int i = 1; i <= n; ++i) fact *= i;
      return fact;
  }
}