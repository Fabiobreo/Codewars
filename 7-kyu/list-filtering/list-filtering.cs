using System.Collections.Generic;
using System.Linq;
​
public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        return listOfItems?.OfType<int>() ?? Enumerable.Empty<int>();
    }
}