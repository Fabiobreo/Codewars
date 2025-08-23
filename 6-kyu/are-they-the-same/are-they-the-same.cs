using System.Collections.Generic;
using System.Linq;
​
class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
      if (a == null || b == null) return false;
      if (a.Length != b.Length) return false;
      
      var dict = new Dictionary<int, int>();
      foreach (var num in b)
      {
          if (!dict.ContainsKey(num))
          {
              dict.Add(num, 0);
          }
          dict[num]++;
      }
    
      foreach (var num in a)
      {
          if (!dict.ContainsKey(num * num)) return false;
          dict[num * num]--;
          if (dict[num * num] == 0) dict.Remove(num * num);
      }
      
    return dict.Count == 0;
  }
}