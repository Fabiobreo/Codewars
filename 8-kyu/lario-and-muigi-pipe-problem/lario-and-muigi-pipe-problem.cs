using System.Collections.Generic;
using System.Linq;
​
public class Fixer
{
  public static List<int> PipeFix(List<int> numbers)
  {
    return Enumerable.Range(numbers[0], numbers[numbers.Count - 1] - numbers[0] + 1).ToList();
  }
}