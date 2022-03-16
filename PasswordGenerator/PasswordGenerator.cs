
using System.Text;

namespace exc.jdbi.PasswordGenerators;

using exc.jdbi.Converts;
using exc.jdbi.PasswordCheckers;
using CRand = Randoms.CryptoRandom;

public sealed partial class PasswordGenerator
{
  /// <summary>
  /// Minimum size of a password.
  /// </summary>
  public const int PASSWORD_MIN_SIZE = 10;
  /// <summary>
  /// Maximum size of a password.
  /// </summary>
  public const int PASSWORD_MAX_SIZE = 1024;

  /// <summary>
  /// Creates a random bytes password. 0 - 255
  /// </summary>
  /// <param name="size">Size of Passwort.</param>
  /// <returns>A new password as array of byte.</returns>
  public static byte[] PasswordBytes(int size)
  {
    var result = new byte[size];
    CRand.NextBytes(result);
    return result;
  }

  /// <summary>
  /// Creates a random password based on the password information.
  /// </summary>
  /// <param name="pwinfo">Password information</param>
  /// <returns>A new Password as string</returns>
  public static string PasswordString(PasswordInfo pwinfo)
  {
    AssertPasswordInfo(pwinfo);
    (var numeric, var upper, var lower) = ToRngAlphaString();
    var special = PasswordCheckers.ToRngSpecialCharacters();
    //var speclen = special.Length;
    var sb = new StringBuilder(pwinfo.Length);

    int counter;
    for (int i = 0; i < pwinfo.Length; i++)
    {
      counter = 0;
      if (pwinfo.NumericLetters)
      {
        sb.Append(numeric[CRand.Next(numeric.Length)]);
        if (pwinfo.Length <= sb.Length) break;
        counter++;
      }
      if (pwinfo.UppercaseCharacters)
      {
        sb.Append(upper[CRand.Next(upper.Length)]);
        if (pwinfo.Length <= sb.Length) break;
        counter++;
      }
      if (pwinfo.LowercaseCharacters)
      {
        sb.Append(lower[CRand.Next(lower.Length)]);
        if (pwinfo.Length <= sb.Length) break;
        counter++;
      }
      if (pwinfo.SpecialCharacters)
      {
        sb.Append(special[CRand.Next(special.Length)]);
        if (pwinfo.Length <= sb.Length) break;
        counter++;
      }
      if (pwinfo.InternationalSymbols)
      {
        sb.Append(RngInternationalSymbol());
        if (pwinfo.Length <= sb.Length) break;
        counter++;
      }
      if (counter == 0)
        //Das würde heissen, dass in pwinfo alles auf false gestellt wäre.
        throw new ArgumentException(
          $"All Arguments in {nameof(pwinfo)} are false", nameof(pwinfo));
      i += counter - 1;
    }

    var result = string.Join(string.Empty, sb.ToString().OrderBy(c => CRand.Next()).ToArray());
    if (pwinfo.StringConvertInfo == StringConvertInfo.None)
      return result;

    return EncodePassword(result, pwinfo);
  }

  /// <summary>
  /// Checks the password strength Only for Alhpanumeric Values.
  /// </summary>
  /// <param name="password">password as string</param>
  /// <returns>Return a PasswordStrength-Datatype.</returns>
  public static PasswordStrength PasswordStrengthChecker(string password)
  //You can use the SecureString too, if it helps you.
  => PasswordCheckers.ToPasswordStrength(password);

  /// <summary>
  /// Checks the password strength.
  /// </summary>
  /// <param name="password">password as array of byte</param>
  /// <returns>Return a PasswordStrength-Datatype.</returns>
  public static PasswordStrength PasswordStrengthChecker(byte[] password)
  //You can use the SecureString too, if it helps you.
  => PasswordCheckers.ToPasswordStrength(password);

  /// <summary>
  /// Converts a string to its equivalent string representation that is encoded.
  /// </summary>
  /// <param name="password">Your password as string</param>
  /// <param name="pwinfo">Password information</param>
  /// <returns>The string representation, in encoding, of the contents of inArray.</returns>
  public static string EncodePassword(string password, PasswordInfo pwinfo)
  => EncodePassword(password, pwinfo.StringConvertInfo);

  /// <summary>
  /// Converts a string to its equivalent string representation that is encoded
  /// </summary>
  /// <param name="password">Your password as string</param>
  /// <param name="convertinfo">Convert information</param>
  /// <returns>The string representation, in encoding, of the contents of inArray.</returns>
  /// <exception cref="NotImplementedException"></exception>
  public static string EncodePassword(string password, StringConvertInfo convertinfo)
  {
    if (StringConvertInfo.None == convertinfo)
      return password;

    var bytes = Encoding.UTF8.GetBytes(password);
    return EncodePassword(bytes, convertinfo);
  }

  public static string EncodePassword(byte[] password, StringConvertInfo convertinfo)
  {
    return convertinfo switch
    {
      StringConvertInfo.Hex => Convert.ToHexString(password),
      StringConvertInfo.Base64 => Convert.ToBase64String(password),
      StringConvertInfo.Base64Url => Base64Url.ToBase64UrlString(password),
      StringConvertInfo.Base62 => Base62.ToBase62String(password),
      StringConvertInfo.Base32 => Base32.ToBase32String(password),
      _ => throw new NotImplementedException()
    };
  }

  /// <summary>
  /// Decode a String-Password. 
  /// Converts the specified string, which encoded digits, to an equivalent string.
  /// </summary>
  /// <param name="password">Your encoded password as string</param>
  /// <param name="pwinfo">Password information</param>
  /// <returns>A string that is equivalent to encpassword</returns>
  public static string DecodePassword(string encpassword, PasswordInfo pwinfo)
  => DecodePassword(encpassword, pwinfo.StringConvertInfo);

  /// <summary>
  /// Decode a String-Password. 
  /// Converts the specified string, which encoded digits, to an equivalent string.
  /// </summary>
  /// <param name="password">Your encoded password as string</param>
  /// <param name="convertinfo">Convert information</param>
  /// <returns>A string that is equivalent to encpassword</returns>
  public static string DecodePassword(string encpassword, StringConvertInfo convertinfo)
  {
    if (convertinfo == StringConvertInfo.None)
      return encpassword; 
    return Encoding.UTF8.GetString(DecodePasswordToBytes(encpassword,convertinfo));
  }

  public static byte[] DecodePasswordToBytes(string encpassword, StringConvertInfo convertinfo)
  {
    if (convertinfo == StringConvertInfo.None)
      return Encoding.UTF8.GetBytes(encpassword);

    var result = Array.Empty<byte>();
    switch (convertinfo)
    {
      case StringConvertInfo.Hex: result = Convert.FromHexString(encpassword); break;
      case StringConvertInfo.Base64: result = Convert.FromBase64String(encpassword); break;
      case StringConvertInfo.Base64Url: result = Base64Url.FromBase64UrlString(encpassword); break;
      case StringConvertInfo.Base62: result = Base62.FromBase62String(encpassword); break;
      case StringConvertInfo.Base32: result = Base32.FromBase32String(encpassword); break;
    }
    return result;
  }
}

