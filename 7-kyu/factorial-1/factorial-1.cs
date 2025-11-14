using System;
​
namespace Solution
{
  public static class Program
  {
    public static ulong Factorial(int n)
    {
        ulong res = 1;
        for (ulong i = 1; i <= (ulong)n; i++)
        {
            res = res * i;
        }
        return res;
    }
  }
}