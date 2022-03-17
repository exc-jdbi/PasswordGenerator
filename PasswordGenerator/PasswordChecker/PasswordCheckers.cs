
namespace exc.jdbi.PasswordCheckers;
using CRand = Randoms.CryptoRandom;

/// <summary>
/// Tools for the determination of the password strength.
/// </summary>
internal sealed class PasswordCheckers
{

  public const int PASSWORD_MIN_SIZE = 10;
  public const int PASSWORD_MAX_SIZE = 1024;

  /// <summary>
  /// Old version of the determination of the password strength.
  /// </summary>
  /// <param name="password">Your Password</param>
  /// <returns>password strength</returns>
  [Obsolete("This method is obsolete. Use ToPasswordStrength instead.", false)]
  internal static PasswordStrength ToPasswordStrengthOld(string password)
  {
    var ints = password.Select(c => Convert.ToInt32(c)).ToArray();
    var sums = ToPasswordSums(ints);
    var score = password.Length * 3;
    Array.ForEach(sums, x => score += Math.Min(2, x) * 4);
    return score switch
    {
      < 50 => PasswordStrength.Unacceptable,
      < 60 => PasswordStrength.Weak,
      < 80 => PasswordStrength.Ok,
      < 100 => PasswordStrength.Strong,
      _ => PasswordStrength.Secure,
    };
  }

  /// <summary>
  /// Efficient determination of password strength.
  /// </summary>
  /// <param name="password">Your Password</param>
  /// <returns>password strength</returns>
  internal static PasswordStrength ToPasswordStrength(string password)
  {
    var ints = password.Select(c => Convert.ToInt32(c)).ToArray();
    return ToPasswordStrength(ints, false);
  }

  /// <summary>
  /// Efficient determination of password strength.
  /// </summary>
  /// <param name="password">Your Password</param>
  /// <returns>password strength</returns>
  internal static PasswordStrength ToPasswordStrength(byte[] password)
  {
    //Die Byte-Variante müsste eigentlich eine eigene 
    //Rpl-Rechnung nachgehen, da die Werte von 0 - 255 sind.
    //Schlussendlich macht das aber auf die Gesamtbewertung,
    //einen sehr kleinen Unterschied, weshalb ich die Byte-
    //Variante auch über die gleiche Berechnung wie die String-
    //Variante laufen lasse.
    var ints = password.Select(c => Convert.ToInt32(c)).ToArray();
    return ToPasswordStrength(ints, true);
  }

  /// <summary>
  /// Efficient determination of password strength.
  /// </summary>
  /// <param name="password">Your Password</param>
  /// <returns>password strength</returns>
  private static PasswordStrength ToPasswordStrength(int[] password, bool _bytevariant)
  {
    AssertPasswordStrength(password);
    var sums = ToPasswordSums(password);
    var rplyears = BfManyRplYears(sums, password.Length);
    var result = ToRplYearsResult(rplyears);

    var shannonentropie = ShannonEntropy(password);
    result += ToShannonEntropieResult(shannonentropie);

    var permutationentropie = PermutationEntropy(password);
    result += ToPermutationEntropyResult(permutationentropie);

    result += ToPasswordLengthResult(password.Length);

    if (_bytevariant && sums[4] == 0)
      //For ByteVariant here 1 point more.
      // because Rng-Items 0 - 255
      result += 1;

    return result switch
    {
      <= 6 => PasswordStrength.Unacceptable,
      <= 8 => PasswordStrength.Weak,
      <= 13 => PasswordStrength.Ok,
      <= 15 => PasswordStrength.Strong,
      _ => PasswordStrength.Secure,
    };
  }

  private static int ToPasswordLengthResult(int passwordlength)
  {
    return passwordlength switch
    {
      <= 8 => 0,
      <= 10 => 1,
      <= 13 => 2,
      <= 16 => 3,
      _ => 4,
    };
  }

  private static int ToShannonEntropieResult(double shannonentropie)
  {
    return shannonentropie switch
    {
      <= 0.8 => 0,
      < 1.2 => 1,
      < 1.75 => 2,
      < 2.85 => 3,
      _ => 4,
    };
  }

  private static int ToPermutationEntropyResult(double permutationentropie)
  {
    return permutationentropie switch
    {
      < 0.0 => 0,
      <= 0.4 => 1,
      <= 0.6 => 2,
      <= 0.8 => 3,
      _ => 4,
    };
  }

  private static int ToRplYearsResult(double rplyears)
  {
    return rplyears switch
    {
      < -.75 => 0,
      < 1.0 => 1,
      < 16.6 => 2,
      < 19.9 => 3,
      _ => 4,
    };
  }

  private static double PermutationEntropy(int[] password, int dimension = 3)
  {
    //Gives information about how many different characters are
    //present in the password, and at the same time, in which
    //relation they are to the neighboring character.
    //>> See and lern more about Google.
    //https://de.wikipedia.org/wiki/Permutationsentropie
    //https://en.wikipedia.org/wiki/Entropy_(information_theory)#Efficiency_(normalized_entropy)

    if (dimension < 2 || dimension > 7)
      throw new ArgumentOutOfRangeException(nameof(dimension));

    var solvmatrix = ToMatrix(password, dimension);

    var permutationdict =
      new Dictionary<int[], int>(new ArrayEqualityComparer());

    foreach (var item in ToColumns(solvmatrix))
    {
      var indexes = Enumerable.Range(0, item.Length).ToArray();
      Array.Sort(indexes, (a, b) => item[a].CompareTo(item[b]));
      if (!permutationdict.ContainsKey(indexes))
        permutationdict.Add(indexes, 1);
      else permutationdict[indexes]++;
    }

    var length = solvmatrix[0].Length;
    var pdv = permutationdict.Values.ToArray();
    var probably = pdv.Select(v => (double)(v / (double)length)).ToArray();
    var relativefrequencies = probably.Select(v => (double)(v * Math.Log(v, 2))).ToArray();
    var permutationentropie = -relativefrequencies.Sum();
    var permutationentropienorm = 1.0 / Math.Log(Factorial(dimension), 2) * permutationentropie;
    return (float)permutationentropienorm;
  }

  private static double ShannonEntropy(int[] password)
  {
    //Provides information about how many different characters
    //are present in the password. 
    //https://en.wikipedia.org/wiki/Entropy_(information_theory)#Definition

    var counts = new Dictionary<int, int>();
    for (int i = 0; i < password.Length; i++)
      if (counts.ContainsKey(password[i]))
        counts[password[i]]++;
      else counts.Add(password[i], 1);

    var values = counts.Values.ToArray();
    var probably = new double[counts.Count];
    for (int i = 0; i < counts.Count; i++)
      probably[i] = values[i] / (double)password.Length;
    return (float)probably.Select(x => x * Math.Log(1 / x, 2)).ToArray().Sum();
  }

  private static double BfManyRplYears(int[] sums, int pwlength)
  {
    //rpl = Erforderliche Passwortlänge
    //rpl = Required Password Length = Minimum Password Length

    var rplpl = ToRplPoolLength(sums, pwlength);

    //Assumption as of 2022
    //SuperComputer >> Calculation ca. 1E12 / sec 
    var years = rplpl - Math.Log2(1e12);
    years -= Math.Log2(3600);     // To hours
    years -= Math.Log2(24);       // To days
    years -= Math.Log2(365);      // To years
    return years - Math.Log2(2);  // half (-1)
  }

  private static double ToRplPoolLength(int[] sums, int pwlength)
  {
    var result = 0;
    if (sums[0] != 0) result += 10;
    if (sums[1] != 0) result += 26;
    if (sums[2] != 0) result += 26;
    if (sums[3] != 0) result += ToRngSpecialCharacters().Length;
    if (sums[4] != 0) result += InternationalSymbolsCount();
    return pwlength * Math.Log(result, 2);
  }

  private static int InternationalSymbolsCount()
  {
    var result = 0;
    for (int i = 0; i <= 65535; i++)
    {
      var c = Convert.ToChar(i);
      if (char.IsLetterOrDigit(c))
        result += 1;
    }
    return result;
  }

  private static int[] ToPasswordSums(int[] password)
  {
    var sums = new int[5];
    var sc = ToRngSpecialCharacters().Select(c => (int)c).ToArray();
    if (!password.Any(c => 0 == c))
    {
      sums[0] = password.Where(c => c >= 48 && c <= 57).Count();
      sums[1] = password.Where(c => c >= 64 && c <= 90).Count();
      sums[2] = password.Where(c => c >= 97 && c <= 122).Count();
      sums[3] = password.Where(c => sc.Contains(c)).Count();
      sums[4] = password.Length - sums.Sum();
      return sums;
    }
    return Array.Empty<int>();
  }

  private static float[][] ToMatrix(int[] data, int n)
  {
    var result = new float[n][];
    var length = data.Length - n + 1;
    for (int i = 0; i < n; i++)
    {
      var item = new float[length];
      for (int j = 0; j < length; j++)
        item[j] = data[j + i];
      result[i] = item;
    }
    return result;
  }

  private static float[][] ToColumns(float[][] matrix)
  {
    var result = new float[matrix[0].Length][];
    for (int i = 0; i < result.Length; i++)
    {
      var item = new float[matrix.Length];
      for (int j = 0; j < matrix.Length; j++)
        item[j] = matrix[j][i];
      result[i] = item;
    }
    return result;
  }

  private static int Factorial(int n)
    => (n == 0) || (n == 1) ? 1 : n * Factorial(n - 1);

  private static void AssertPasswordStrength(int[] password)
  {
    if (password is null ||
        password.Length < PASSWORD_MIN_SIZE ||
        password.Length > PASSWORD_MAX_SIZE)
      throw new ArgumentOutOfRangeException(nameof(password));
  }

  internal static string ToRngSpecialCharacters()
  => string.Join(string.Empty, " !\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~".OrderBy(c => CRand.Next()));

}

