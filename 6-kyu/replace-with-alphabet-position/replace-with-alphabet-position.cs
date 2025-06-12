using System.Linq;
​
public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(ch => ch - 'a' + 1));
  }
}