using System;
using System.Linq;
​
public class Kata
{
  public static int SquareDigits(int n)
  {
      return int.Parse(string.Join("", n.ToString().Select(ch => (ch - '0') * (ch - '0'))));
  }
}