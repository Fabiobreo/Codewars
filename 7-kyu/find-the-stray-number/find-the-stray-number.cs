using System.Collections.Generic;
​
class Solution 
{
  public static int Stray(int[] numbers)
  {
    var dict = new Dictionary<int, int>();
    foreach (var num in numbers)
    {
        if (!dict.ContainsKey(num)) dict.Add(num, 0);
        dict[num]++;
    }
    
    foreach (var key in dict.Keys)
    {
        if (dict[key] == 1) return key;
    }
    return -1;
  }
}