using System;
​
namespace Solution
{
  class Kata
    {
      public static int binaryArrayToNumber(int[] BinaryArray)
        {
            int result = 0;
            for (int i = 0; i < BinaryArray.Length; i++)
            {
                result += BinaryArray[i] * (int)Math.Pow(2, BinaryArray.Length - i - 1);
            }
            return result;
        }
    }
}