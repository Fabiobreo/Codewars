public class Kata
{
  public static string Remove(string s)
  {
      while (s.EndsWith("!")) s = s.Substring(0, s.Length - 1);
      return s;
  }
}
​