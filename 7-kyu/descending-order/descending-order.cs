using System;
using System.Text;
​
public static class Kata
{
  public static int DescendingOrder(int num)
  {
    int[] freq = new int[10];
    var numStr = num.ToString();
    for (int i = 0; i < numStr.Length; ++i)
    {
      freq[numStr[i] - '0']++;
    }
    
    var builder = new StringBuilder();
    for (int i = freq.Length - 1; i >= 0; i--)
    {
        while (freq[i] > 0)
        {
            builder.Append(i.ToString());
            freq[i]--;
        }
    }
    return int.Parse(builder.ToString());
  }
}
​