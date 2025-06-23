using System.Text;
​
public class Kata
{
  public static string FakeBin(string x)
  {
      StringBuilder builder = new();
      foreach (var ch in x)
      {
          if (ch < '5')
          {
              builder.Append('0');
          }
          else
          {
              builder.Append('1');
          }
      }
      return builder.ToString();
  }
}