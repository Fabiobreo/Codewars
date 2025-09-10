public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
      int total = 0;
      foreach (var x in arr) total += x;
​
      int left = 0;
      for (int i = 0; i < arr.Length; i++)
      {
          int right = total - left - arr[i];
          if (left == right) return i;
          left += arr[i];
      }
      return -1;
  }
}