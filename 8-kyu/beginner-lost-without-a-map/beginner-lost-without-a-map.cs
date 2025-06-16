using System.Linq;
​
public class Kata
{
  public static int[] Maps(int[] x)
  {
    return x.Select(x => x * 2).ToArray();
  }
}