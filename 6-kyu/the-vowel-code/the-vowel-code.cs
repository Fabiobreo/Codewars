using System.Collections.Generic;
​
public static class VowelCode
{
  private static Dictionary<char, char> encoder = new Dictionary<char, char>()
  {
      { 'a', '1' }, { 'e', '2' }, { 'i', '3' }, { 'o', '4' }, { 'u', '5' }
  };
  
  private static Dictionary<char, char> decoder = new Dictionary<char, char>()
  {
      { '1', 'a' }, { '2', 'e' }, { '3', 'i' }, { '4', 'o' }, { '5', 'u' }
  };
  
  public static string Encode(string msg)
  {
      var charArray = msg.ToCharArray();
      for (int i = 0; i < charArray.Length; ++i)
      {
          if (encoder.ContainsKey(charArray[i]))
          {
              charArray[i] = encoder[charArray[i]];
          }
      }
      return new string(charArray);
  }
  
  public static string Decode(string msg)
  {
      var charArray = msg.ToCharArray();
      for (int i = 0; i < charArray.Length; ++i)
      {
          if (decoder.ContainsKey(charArray[i]))
          {
              charArray[i] = decoder[charArray[i]];
          }
      }
      return new string(charArray);
  }
}
​