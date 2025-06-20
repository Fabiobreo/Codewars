using System;
​
public class Persist 
{
  public static int Persistence(long n) 
  {
      int times = 0;
      string number = n.ToString();
      while (number.Length > 1)
      {
          int mult = 1;
          foreach (var ch in number)
          {
              mult *= (ch - '0');
          }
          times++;
          number = mult.ToString();
      }
      return times;
  }
}