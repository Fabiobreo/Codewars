using System;
​
public class Kata
{
  public static string Problem(String a)
  {
    if (double.TryParse(a, out double num)) return (num * 50 + 6).ToString();
    return "Error";
  }
}