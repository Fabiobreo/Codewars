using System.Collections.Generic;
using System.Linq;
​
public static class Kata
{
  public static int[] Capitals(string word)
  {
    List<int> list = new();
    for (int i = 0; i < word.Length; ++i)
    {
        if (char.IsUpper(word[i])) list.Add(i);
    }
    return list.ToArray();
  }
}