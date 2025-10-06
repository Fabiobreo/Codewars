using System.Collections.Generic;
using System.Linq;
​
public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            List<object> rest = new();
            for (int i = 0; i < arr.Length; ++i)
            {
                if (i % 2 == 1) continue;
                rest.Add(arr[i]);
            }
            return rest.ToArray();
        }
    }