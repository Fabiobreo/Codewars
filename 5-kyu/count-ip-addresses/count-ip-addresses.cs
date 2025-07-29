using System;
using System.Linq;
​
public class CountIPAddresses
{
   public static long IpsBetween(string start, string end)
   {
      return To32Bit(end) - To32Bit(start);
   }
  
    private static uint To32Bit(string ip)
    {
        var octets = ip.Split('.').Select(byte.Parse).ToArray();
        return ((uint)octets[0] << 24) |
               ((uint)octets[1] << 16) |
               ((uint)octets[2] << 8) |
                (uint)octets[3];
    }
}