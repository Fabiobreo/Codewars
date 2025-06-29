using System.Linq;
​
public class Kata
{
  public static string DoubleChar(string s)
  {
    return string.Concat(s.Select(ch => ch + "" + ch));
  }
}