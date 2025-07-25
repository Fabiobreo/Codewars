using System;
using System.Collections.Generic;
using System.Linq;
​
public class Kata
{
    public static int Number(List<int[]> peopleListInOut)
    {
        return peopleListInOut.Sum(a => a[0] - a[1]);
    }
}