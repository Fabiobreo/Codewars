using System;
​
public class Kata
{
      public static int CalculateYears(double principal, double interest,  double tax, double desiredPrincipal)
      {
          int years = 0;
          while (principal < desiredPrincipal)
          {
              double earned = principal * interest * (1 - tax);
              principal += earned;            
              years++;
          }
          return years;
      }
}