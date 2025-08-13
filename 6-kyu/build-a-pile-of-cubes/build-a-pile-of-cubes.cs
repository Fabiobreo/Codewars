using System;
​
public class ASum
{
  
  public static long findNb(long m)
  {
      long k = (long)Math.Sqrt(m);
      if (k * k != m) return -1;      
    
      long disc = 1 + 8 * k;
      long s    = (long)Math.Sqrt(disc);
      if (s * s != disc) return -1;   
    
      long n = (s - 1) / 2;
      return n * (n + 1) / 2 == k ? n : -1;
  }
  
}
​