using System;
using System.Collections.Generic;
​
namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
        var text = n.ToString();
        var result = new long[text.Length];
        for (int i = text.Length - 1; i >= 0; i--)
        {
            result[text.Length - i - 1] = text[i] - '0';
        }
        return result;
    }
  }
}