using System.Globalization;
using System.Text;

namespace exc.jdbi.PasswordGenerators;
using CRand = Randoms.CryptoRandom;

partial class PasswordGenerator
{


  private static char RngInternationalSymbol()
  {
    char result;
    while (true)
    {
      result = Convert.ToChar(CRand.Next(256, 65530));
      if (char.IsLetterOrDigit(result)) return result;
    }
  }

  private static (string NumericStr, string UpperStr, string LowerStr) ToRngAlphaString()
  {
    var alpha = AlphaString();
    var numbers = string.Join(string.Empty, alpha.Take(10).OrderBy(c => CRand.Next()));
    var upper = string.Join(string.Empty, alpha.Skip(10).Take(26).OrderBy(c => CRand.Next()));
    var lower = string.Join(string.Empty, alpha.Skip(36).ToArray().OrderBy(c => CRand.Next()));
    return (numbers, upper, lower);
  }

  private static string AlphaString()
  {
    var res = new StringBuilder(62);
    var cultur = new CultureInfo("en-us", false);
    var z = new byte[] { 48, 57, 65, 90, 97, 122 };
    for (int i = 0; i < z.Length; i += 2)
      for (byte j = z[i]; j <= z[i + 1]; j++)
        res.Append(Convert.ToChar(j, cultur));
    return res.ToString();
  }

  private static void AssertPasswordInfo(PasswordInfo pwinfo)
  {
    if (pwinfo.Length < PASSWORD_MIN_SIZE)
      throw new ArgumentOutOfRangeException(nameof(pwinfo),
        $"Password must be at least length = {PASSWORD_MIN_SIZE}");

    if (pwinfo.Length > PASSWORD_MAX_SIZE)
      throw new ArgumentOutOfRangeException(nameof(pwinfo),
        $"Password must be maximale length = {PASSWORD_MAX_SIZE}");
  }

  private static string ToRngSpecialCharacters()
    => string.Join(string.Empty, " !\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~".OrderBy(c => CRand.Next()));
}