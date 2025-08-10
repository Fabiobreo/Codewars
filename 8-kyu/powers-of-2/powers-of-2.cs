using System.Numerics;
using System;
​
public class Kata
{
  public static BigInteger[] PowersOfTwo(int n)
  {
    var result = new BigInteger[n + 1];
    for (int i = 0; i <= n; ++i)
    {
      result[i] = (BigInteger)Math.Pow(2, i);
    }
    return result;
  }
}