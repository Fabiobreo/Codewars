using System.Collections.Generic;
using System.Linq;
​
public static class Kata
{
  public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
  {
      if (iterable == null)
      {
          yield break;
      }
      T lastElement = default(T);
      bool isFirstElement = true;
      foreach (var element in iterable)
      {
          if (isFirstElement || !EqualityComparer<T>.Default.Equals(element, lastElement))
          {
              yield return element;
              lastElement = element;
              isFirstElement = false;
          }
      }
  }
}