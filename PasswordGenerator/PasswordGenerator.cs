
using System.Text;

namespace exc.jdbi.PasswordGenerators;

using exc.jdbi.Converts;
using exc.jdbi.PasswordCheckers;
using CRand = Randoms.CryptoRandom;

public partial class PasswordGenerator
{

  public const int PASSWORD_MIN_SIZE = 10;
  public const int PASSWORD_MAX_SIZE = 1024;

  /// <summary>
  /// 
  /// </summary>
  /// <param name="size"></param>
  /// <returns></returns>
  public static byte[] PasswordBytes(int size)
  {
    var result = new byte[size];
    CRand.NextBytes(result);
    return result;
  }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="pwinfo">Password information</param>
  /// <returns></returns>
  public static string PasswordString(PasswordInfo pwinfo)
  {
    AssertPasswordInfo(pwinfo);
    (var numeric, var upper, var lower) = ToRngAlphaString();
    var special = ToRngSpecialCharacters();
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
        //Das würde heissen, dass in pwinfo alles
        //auf false gestellt wäre.
        throw new ArgumentException(nameof(pwinfo));
      i += counter - 1;
    }

    var result = string.Join(string.Empty, sb.ToString().OrderBy(c => CRand.Next()).ToArray());
    if (pwinfo.StringConvertInfo == StringConvertInfo.None)
      return result;

    return EncodePassword(result, pwinfo);
  }

  /// <summary>
  /// Checks the password strength
  /// </summary>
  /// <remarks>
  /// Samples are here: <para/>
  /// <seealso href="link">http://www.blackwasp.co.uk/</seealso><para/>
  /// <seealso href="link">https://stackoverflow.com/questions/12899876/checking-strings-for-a-strong-enough-password</seealso> 
  /// </remarks>
  /// <param name="password">password as string</param>
  /// <returns>Return a PasswordStrength-Datatype.</returns>
  public static PasswordStrength PasswordStrengthChecker(string password)
  //You can use the SecureString too, if it helps you.
  => PasswordCheckers.ToPasswordStrength(password);

  /// <summary>
  /// Encode a StringPassword.
  /// </summary>
  /// <param name="password">Your password as string</param>
  /// <param name="pwinfo">Password information</param>
  /// <returns></returns>
  public static string EncodePassword(string password, PasswordInfo pwinfo)
  {

    var sci = pwinfo.StringConvertInfo;
    var bytes = Encoding.UTF8.GetBytes(password);
    return sci switch
    {
      StringConvertInfo.None => password,
      StringConvertInfo.Hex => Convert.ToHexString(bytes),
      StringConvertInfo.Base64 => Convert.ToBase64String(bytes),
      StringConvertInfo.Base62 => Base62.ToBase62String(bytes),
      StringConvertInfo.Base32 => Base32.ToBase32String(bytes),
      _ => throw new NotImplementedException()
    };
  }

  /// <summary>
  /// Decode a StringPassword.
  /// </summary>
  /// <param name="password">Your encoded password as string</param>
  /// <param name="pwinfo">Password information</param>
  /// <returns></returns>
  public static string DecodePassword(string password, PasswordInfo pwinfo)
  => DecodePassword(password, pwinfo.StringConvertInfo);

  /// <summary>
  /// Decode a StringPassword.
  /// </summary>
  /// <param name="password">Your encoded password as string</param>
  /// <param name="convertinfo">Convert information</param>
  /// <returns></returns>
  public static string DecodePassword(string password, StringConvertInfo convertinfo)
  {
    if (convertinfo == StringConvertInfo.None)
      return password;

    var result = Array.Empty<byte>();
    switch (convertinfo)
    {
      case StringConvertInfo.Hex: result = Convert.FromHexString(password); break;
      case StringConvertInfo.Base64: result = Convert.FromBase64String(password); break;
      case StringConvertInfo.Base62: result = Base62.FromBase62String(password); break;
      case StringConvertInfo.Base32: result = Base32.FromBase32String(password); break;
    }
    return Encoding.UTF8.GetString(result);
  }
}

