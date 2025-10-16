using System.Linq;
​
public class Kata
{
  public static string[] AddLength(string str)
  {
      return str.Split(" ").Select(word => $"{word} {word.Length}").ToArray();
  }
}