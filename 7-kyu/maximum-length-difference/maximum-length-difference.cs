using System;
using System.Linq;
​
public class MaxDiffLength 
{
    public static int Mxdiflg(string[] a1, string[] a2) 
    {
        a1 = a1.OrderBy(a => a.Length).ToArray();
        a2 = a2.OrderBy(a => a.Length).ToArray();
        if (a1.Length == 0 || a2.Length == 0) return -1;
        return Math.Max(a1[a1.Length - 1].Length - a2[0].Length, a2[a2.Length - 1].Length - a1[0].Length);
    }
}