using System.Text;


namespace exc.jdbi.Converts;

/// <summary> 
/// Converts a subset of an array of 8-bit unsigned integers to its 
/// equivalent string representation that is encoded with Base32 digits.
/// </summary>
public class Base32
{
  private const int SHIFT_SIZE = 5;
  private const int MASK_SIZE = 31;
  private static string Digits = string.Empty;

  /// <summary>
  /// Converts an array of 8-bit unsigned integers to its equivalent string representation
  /// that is encoded with Base32 digits.
  /// </summary>
  /// <param name="data">An array of 8-bit unsigned integers.</param>
  /// <param name="_withpaddings">Option: Paddings</param>
  /// <param name="defaultstr">Option: Your Character-Set</param>
  /// <returns>The string representation, in base 32, of the contents of data.</returns>
  public static string ToBase32String(byte[] data, bool _withpaddings = false, string? defaultstr = null)
  {
    AssertBase32(data, defaultstr);
    if (data.Length == 0) return string.Empty;
    Digits = string.IsNullOrEmpty(defaultstr) ? DefaultDigits() : defaultstr;

    var resultlength = (data.Length * 8 + SHIFT_SIZE - 1) / SHIFT_SIZE;
    var result = new StringBuilder(resultlength);

    var bitsleft = 8;
    var length = data.Length;
    int buffer = data.First();
    for (int i = 0, j = 1; i < resultlength; i++)
    {
      if (bitsleft < SHIFT_SIZE)
      {
        if (j < length)
        {
          buffer <<= 8;
          buffer |= data[j++] & 0xff;
          bitsleft += 8;
        }
        else
        {
          int pad = SHIFT_SIZE - bitsleft;
          buffer <<= pad;
          bitsleft += pad;
        }
      }
      int index = MASK_SIZE & (buffer >> (bitsleft - SHIFT_SIZE));
      bitsleft -= SHIFT_SIZE;
      result.Append(Digits[index]);
    }
    if (_withpaddings)
    {
      int padding = 8 - (result.Length % 8);
      if (padding > 0) result.Append('=', padding == 8 ? 0 : padding);
    }
    return result.ToString();
  }

  /// <summary>
  /// Decode a previously encoded value.
  /// </summary>
  /// <param name="base32str">The string to convert.</param>
  /// <param name="defaultstr">Option: Your Character-Set</param>
  /// <returns>An array of 8-bit unsigned integers that is equivalent to base32str.</returns>
  /// <exception cref="FormatException"></exception>
  public static byte[] FromBase32String(string base32str, string? defaultstr = null)
  {
    AssertBase32(base32str, defaultstr);
    base32str = base32str.Trim().TrimEnd('=').ToUpper();
    if (base32str.Length == 0) return Array.Empty<byte>();

    var resultlength = base32str.Length * SHIFT_SIZE / 8;
    var result = new byte[resultlength];

    int index;
    var next = 0;
    var buffer = 0;
    var bitsleft = 0;
    foreach (var c in base32str)
    {
      index = ToIndex(c);
      if (index < 0)
        throw new FormatException(
          $"Illegal character: '{c}'");

      buffer <<= SHIFT_SIZE;
      buffer |= index & MASK_SIZE;
      bitsleft += SHIFT_SIZE;
      if (bitsleft >= 8)
      {
        result[next++] = (byte)(buffer >> (bitsleft - 8));
        bitsleft -= 8;
      }
    }
    return result;

  }

  private static int ToIndex(char c)
  => Digits.IndexOf(c);


  private static void AssertBase32(byte[] data, string? defaultstr)
  {
    if (data is null)
      throw new ArgumentNullException(nameof(data));

    if (!string.IsNullOrEmpty(defaultstr) && defaultstr.Length != 32)
      throw new ArgumentOutOfRangeException(nameof(defaultstr));
  }
  private static void AssertBase32(string base32str, string? defaultstr)
  {
    if (string.IsNullOrEmpty(base32str))
      throw new ArgumentNullException(nameof(base32str));

    if (!string.IsNullOrEmpty(defaultstr) && defaultstr.Length != 32)
      throw new ArgumentOutOfRangeException(nameof(defaultstr));
  }

  private static string DefaultDigits()
    => "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";
}
