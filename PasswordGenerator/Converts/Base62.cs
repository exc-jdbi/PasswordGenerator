
using System.Text;

namespace exc.jdbi.Converts;

/// <summary>
/// Converts a subset of an array of 8-bit unsigned integers to its 
/// equivalent string representation that is encoded with Base62 digits.
/// </summary>
public sealed class Base62
{
  private const char CodeFlag = '9';
  private static string Digits = string.Empty;

  /// <summary>
  /// Encode to Base62
  /// </summary>
  /// <param name="data">Array of 8-bit unsigned integers.</param>
  /// <param name="defaultstr">Option: Your Character-Set</param>
  /// <returns>The string representation, in base62, of the contents of data.</returns>
  public static string ToBase62String(byte[] data, string? defaultstr = null)
  {
    //Nur für kleine Arraylängen, da die Base62-Konvertierung über
    //das Zahlensystem bewerksteligt wird. Nsc hat einfach seine Zeit.
    AssertBase62(data, defaultstr);
    if (data.Length == 0) return string.Empty;
    Digits = string.IsNullOrEmpty(defaultstr) ? DefaultDigits() : defaultstr;

    var nsc = Nsc(data, 256, 62);
    var result = new StringBuilder();
    foreach (var c in nsc)
      result.Append(Digits[c]);
    return result.ToString();
  }

  /// <summary>
  /// Decode a previously encoded value.
  /// </summary>
  /// <param name="base62str">The string to convert.</param>
  /// <param name="defaultstr">Option: Your Character-Set</param>
  /// <returns>An array of 8-bit unsigned integers that is equivalent to base62str.</returns>
  public static byte[] FromBase62String(string base62str, string? defaultstr = null)
  {
    //Nur für kleine Arraylängen, da die Base62-Konvertierung über
    //das Zahlensystem bewerksteligt wird. Nsc hat einfach seine Zeit.
    AssertBase62(base62str, defaultstr);
    Digits = string.IsNullOrEmpty(defaultstr) ? DefaultDigits() : defaultstr;

    var arr = new byte[base62str.Length];
    for (var i = 0; i < arr.Length; i++)
      arr[i] = (byte)Digits.IndexOf(base62str[i]);

    return Nsc(arr, 62, 256);
  }


  /// <summary>
  /// Very fast converter that does not follow the regular Base62 guidelines.
  /// Convert a Byte-Array in a not regular Base62 Encoding.
  /// <para>Important: Not all Character-Sets works</para>
  /// </summary>
  /// <remarks>
  /// Special thanks to 
  /// <seealso href="link">https://github.com/tuldok89</seealso> 
  /// </remarks>
  /// <param name="data">Array of 8-bit unsigned integers.</param>
  /// <param name="defaultstr">Option: Your Character-Set</param>
  /// <returns>The string representation, in base62, of the contents of data.</returns>
  public static string ToBase62StringSpec(byte[] data, string? defaultstr = null)
  {
    AssertBase62(data, defaultstr);
    if (data.Length == 0) return string.Empty;
    Digits = string.IsNullOrEmpty(defaultstr) ? DefaultDigitsSpec() : defaultstr;

    int b = 0;
    bool flag = true;
    var result = new StringBuilder(data.Length * 2);

    for (int i = 0; i < data.Length; i++)
    {
      switch (i % 3)
      {
        case 0:
          {
            flag = true;
            b = (data[i] & 0xFC) >> 2;
            Append(b, result);
            b = (data[i] & 0x03) << 4;
            break;
          }
        case 1:
          {
            flag = true;
            b |= (data[i] & 0xF0) >> 4;
            Append(b, result);
            b = (data[i] & 0x0F) << 2;
            break;
          }
        case 2:
          {
            flag = false;
            b |= (data[i] & 0xC0) >> 6;
            Append(b, result);
            b = data[i] & 0x3F;
            Append(b, result);
            break;
          }
      }
    }
    if (flag)
      Append(b, result);
    return result.ToString();
  }

  /// <summary>
  /// Very fast converter that does not follow the regular Base62 guidelines.
  /// Convert a not regular Base62 Encoding to a Byte-Array.
  /// <para>Important: Not all Character-Sets works</para>
  /// </summary>
  /// <remarks>
  /// Special thanks to 
  /// <seealso href="link">https://github.com/tuldok89</seealso> 
  /// </remarks>
  /// <param name="base62specstr">The string to convert.</param>
  /// <param name="defaultstr">Option: Your Character-Set</param>
  /// <returns>An array of 8-bit unsigned integers that is equivalent to base62specstr.</returns>
  /// <exception cref="ArgumentOutOfRangeException"></exception>
  public static byte[] FromBase62StringSpec(string base62specstr, string? defaultstr = null)
  {
    AssertBase62(base62specstr, defaultstr);
    Digits = string.IsNullOrEmpty(defaultstr) ? DefaultDigitsSpec() : defaultstr;

    byte b;
    char ch;
    int m = 0;
    bool cflag = false;
    var unit = new int[4];
    var codemap = ToNewCodeMap();
    int length = base62specstr.Length;
    var result = new List<byte>(length);

    for (int n = 0; n < length; n++)
    {
      ch = base62specstr[n];
      if (ch != CodeFlag && !cflag)
      {
        unit[m] = Digits.IndexOf(ch);
        m++;
      }
      else if (ch != CodeFlag && cflag)
      {
        cflag = false;
        unit[m] = codemap[ch];
        m++;
      }
      else
      {
        cflag = true;
        continue;
      }

      if (m == 4)
      {
        b = (byte)((unit[0] << 2) | (unit[1] >> 4));
        result.Add(b);
        b = (byte)((unit[1] << 4) | (unit[2] >> 2));
        result.Add(b);
        b = (byte)(unit[2] << 6 | unit[3]);
        result.Add(b);
        m = 0;
      }
    }
    switch (m)
    {
      case 0: break;
      case 1:
        {
          b = (byte)(unit[0] << 2);
          result.Add(b);
          break;
        }
      case 2:
        {
          b = (byte)((unit[0] << 2) | (unit[1] >> 4));
          result.Add(b);
          break;
        }
      case 3:
        {
          b = (byte)((unit[0] << 2) | (unit[1] >> 4));
          result.Add(b);
          b = (byte)((unit[1] << 4) | (unit[2] >> 2));
          result.Add(b);
          break;
        }
      default:
        throw new ArgumentOutOfRangeException(nameof(m),
          $"{nameof(m)} must be 0 - 3");
    }
    codemap.Clear();
    return result.ToArray();
  }


  /// <summary>
  /// <seealso href="link">
  /// https://www.vb-paradise.de/index.php/Thread/121201-NSC-Zahlensysteme-umrechnen-von-einer-Basis-in-ein-Anderes/
  /// </seealso> 
  /// </summary>
  /// <param name="data"></param>
  /// <param name="startbase"></param>
  /// <param name="targetbase"></param>
  /// <returns></returns>
  private static byte[] Nsc(byte[] data, int startbase, int targetbase)
  {
    int cap = Convert.ToInt32(data.Length * Math.Log(startbase) / Math.Log(targetbase)) + 1;
    var result = new Stack<byte>(cap);

    byte remainder;
    bool ext = true;
    byte accumulator;
    var cntzeros = 0;
    var input = data.ToArray();
    if (input[0] == 0)
      cntzeros = CountZeros(input);
    while (ext)
    {
      remainder = 0; ext = false;
      for (int i = 0; i < input.Length; i++)
      {
        accumulator = (byte)(((startbase * remainder) + input[i]) % targetbase);
        input[i] = (byte)(((startbase * remainder) + input[i]) / targetbase);
        remainder = accumulator;
        if (input[i] > 0) ext = true;
      }
      result.Push(remainder);
    }
    if (cntzeros > 0)
      for (int i = 0; i < cntzeros; i++)
        result.Push(0);
    return result.ToArray();
  }

  private static void Append(int b, StringBuilder sb)
  {
    if (b < 61)
    {
      sb.Append(Digits[b]);
    }
    else
    {
      sb.Append(CodeFlag);
      sb.Append(Digits[b - 61]);
    }
  }

  public static byte[] CleanPreviousZeros(byte[] bytes)
  {
    //Vorangehende Nullen werden von Nsc beachtet, und wieder
    //als vorangehende Nullen hinzugefügt.
    int count = 0, idx = 0;
    while (bytes[idx++] == 0) count++;
    return bytes.Skip(count).ToArray();
  }

  private static int CountZeros(byte[] bytes)
  {
    int count = 0, idx = 0;
    while (bytes[idx++] == 0) count++;
    return count;
  }

  private static void AssertBase62(byte[] data, string? defaultstr)
  {
    if (data is null)
      throw new ArgumentNullException(nameof(data));

    if (!string.IsNullOrEmpty(defaultstr) && defaultstr.Length != 62)
      throw new ArgumentOutOfRangeException(nameof(defaultstr));
  }

  private static void AssertBase62(string base32str, string? defaultstr)
  {
    if (string.IsNullOrEmpty(base32str))
      throw new ArgumentNullException(nameof(base32str));

    if (!string.IsNullOrEmpty(defaultstr) && defaultstr.Length != 62)
      throw new ArgumentOutOfRangeException(nameof(defaultstr));
  }

  private static Dictionary<char, int> ToNewCodeMap()
    => new() { { 'A', 61 }, { 'B', 62 }, { 'C', 63 } };

  private static string DefaultDigits()
    => "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
  private static string DefaultDigitsSpec()
    //Die Zahlen müssen immer am Schluss sein.
    => "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

}
