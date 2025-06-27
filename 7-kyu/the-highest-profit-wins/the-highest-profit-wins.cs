using System;
using System.Linq;
​
public class MinMax 
{
    public static int[] minMax(int[] lst) 
    {
       return new int[2] {lst.Min(), lst.Max()};
    }
}