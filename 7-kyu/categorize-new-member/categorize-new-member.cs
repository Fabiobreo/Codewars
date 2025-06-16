using System;
using System.Collections.Generic;
using System.Linq;
​
public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        return data.Select(entry => entry[0] >= 55 && entry[1] > 7 ? "Senior" : "Open");
    }
}