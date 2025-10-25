using System;
using System.Globalization;
​
public static class Kata
{
  public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
  {
    if (enteredCode == null || correctCode == null) return false;
    if (!string.Equals(enteredCode, correctCode, StringComparison.Ordinal)) return false;
    
    const string format = "MMMM d, yyyy";
    var culture = CultureInfo.InvariantCulture;
    var styles = DateTimeStyles.AllowWhiteSpaces;
​
    if (!DateTime.TryParseExact(currentDate, format, culture, styles, out var current))
      return false;
​
    if (!DateTime.TryParseExact(expirationDate, format, culture, styles, out var expiration))
      return false;
​
    return current.Date <= expiration.Date;
  }
}