using System;
​
public static class Kata
{
    public static string Disemvowel(string str)
    {
        return str.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
          .Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", "");
    }
}