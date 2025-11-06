using System.Collections.Generic;
using System.Linq;
​
public class Kata
{
    public static List<int> FindMultiples(int n, int limit)
    {
        return Enumerable.Range(1, limit / n).Select(i => i * n).ToList();
    }
}