using System.Linq;
using System.Text;
​
public class CountDig 
{
    public static int NbDig(int n, int d) 
    {
      StringBuilder builder = new();
      for (int i = 0; i <= n; ++i)
      {
        builder.Append((i * i).ToString());
      }
      return builder.ToString().Count(ch => ch - '0' == d);
    }
}