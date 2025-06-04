using System;
using System.Numerics;

public class Fibonacci
{

    public static BigInteger fib(int n)
    {
        if (n == 0) return 0;
      
        bool negate = n < 0 && (n & 1) == 0;
        ulong k = (ulong)Math.Abs(n);
      
        BigInteger val = FibPair(k).Item1;
      
        return negate ? - val : val;
    }
  
    private static (BigInteger, BigInteger) FibPair(ulong n)
    {
        if (n == 0) return (0, 1);
      
        (BigInteger a, BigInteger b) = FibPair(n >> 1);
        BigInteger c = a * ((b << 1) - a);
        BigInteger d = a * a + b * b;
        return (n & 1) == 0 ? (c, d) : (d, c + d);
    }
}
