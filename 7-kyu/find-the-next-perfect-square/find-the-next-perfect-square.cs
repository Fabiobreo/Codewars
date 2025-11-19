using System;
​
public class Kata
{
  public static long FindNextSquare(long n)
  {
      if (n < 0) return -1;
        long root = (long)Math.Sqrt(n);
        if (root * root != n) return -1;
        root++;
        try
        {
            checked
            {
                return root * root;
            }
        }
        catch (OverflowException)
        {
            return -1;
        }
  }
}