using System;
using System.Globalization;
​
public class Kata
{
  public static int HexToDec(string hex)
  {
    if (hex == null)
            throw new ArgumentNullException(nameof(hex));
        hex = hex.Trim();
        if (hex.Length == 0)
            throw new ArgumentException("Empty string is not a valid hex number.", nameof(hex));
        // Handle optional leading minus sign
        bool isNegative = false;
        if (hex[0] == '-')
        {
            isNegative = true;
            hex = hex.Substring(1);
            if (hex.Length == 0)
                throw new FormatException("'-' is not a valid hex number.");
        }
        int result = 0;
        foreach (char c in hex)
        {
            int value;
            if (c >= '0' && c <= '9')
            {
                value = c - '0';
            }
            else if (c >= 'A' && c <= 'F')
            {
                value = 10 + (c - 'A');
            }
            else if (c >= 'a' && c <= 'f')
            {
                value = 10 + (c - 'a');
            }
            else
            {
                throw new FormatException($"Invalid hex character: '{c}'");
            }
            checked
            {
                result = result * 16 + value;
            }
        }
        return isNegative ? -result : result;
  }
}