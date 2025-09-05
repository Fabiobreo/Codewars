using System;
​
public class Kata
{
  public static char GetGrade(int s1, int s2, int s3)
  {
    double avg = (s1 + s2 + s3) / 3.0;
    if (avg >= 90) return 'A';
    if (avg >= 80) return 'B';
    if (avg >= 70) return 'C';
    if (avg >= 60) return 'D';
    
    return 'F';
  }
}