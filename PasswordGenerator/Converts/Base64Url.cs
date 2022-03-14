using System.Text;

namespace exc.jdbi.Converts;

/// <summary> 
/// Converts a subset of an array of 8-bit unsigned integers to its 
/// equivalent string representation that is encoded with Base64Url digits.
/// </summary>
public class Base64Url
{
  /// <summary>
  /// Converts an array of 8-bit unsigned integers to its 
  /// equivalent string representation that is encoded with Base64Url digits.
  /// </summary>
  /// <param name="bytes">An array of 8-bit unsigned integers.</param>
  /// <returns>The string representation, in Base64Url, of the contents of bytes.</returns>
  public static string ToBase64UrlString(byte[] bytes)
  { 
    var result = Convert.ToBase64String(bytes);
    result = result.Split('=')[0];     // First pad before '=' 
    result = result.Replace('+', '-'); // 62nd 
    result = result.Replace('/', '_'); // 63rd 
    return result;
  }

  /// <summary>
  /// Converts the specified string, which encodes binary data as Base64Url  
  /// digits, to an equivalent 8-bit unsigned integer array.
  /// </summary>
  /// <param name="base64urlstr">The string to convert.</param>
  /// <returns>An array of 8-bit unsigned integers that is equivalent to base64urlstr.</returns>
  /// <exception cref="FormatException">Illegal Base64url string!</exception>
  public static byte[] FromBase64UrlString(string base64urlstr)
  {
    //Copy String (New String)
    var result = new StringBuilder(base64urlstr).ToString();
    result = result.Replace('-', '+'); // 62nd
    result = result.Replace('_', '/'); // 63rd

    switch (result.Length % 4)
    {
      case 0: break;                  // No pad
      case 2: result += "=="; break;  // Two pad 
      case 3: result += "="; break;   // One pad 
      default: throw new FormatException("Illegal base64url string!");
    }
    return Convert.FromBase64String(result);  
  }
}
