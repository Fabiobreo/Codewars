using System;
​
public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    {
        return (flower1 + flower2) % 2 == 1;
    }
}