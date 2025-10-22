using System;
using System.Collections.Generic;
​
public class SumDigPower
{
    public static long[] SumDigPow(long a, long b)
    {
        if (b < a) return new long[0];
        long start = Math.Max(1, a);
        List<long> result = new List<long>();
        for (long n = start; n <= b; n++)
        {
            if (IsEureka(n))
            {
                result.Add(n);
            }
            if (n == long.MaxValue) break;
        }
        return result.ToArray();
    }
  
    private static bool IsEureka(long n)
    {
        char[] digits = n.ToString().ToCharArray();
        long sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            int d = digits[i] - '0';
            long term = Ipow(d, i + 1);
            if (term > n - sum) return false;
            sum += term;
        }
        return sum == n;
    }
  
    private static long Ipow(int bas, int exp)
    {
        long res = 1;
        for (int i = 0; i < exp; i++)
        {
            res *= bas;
        }
        return res;
    }
}