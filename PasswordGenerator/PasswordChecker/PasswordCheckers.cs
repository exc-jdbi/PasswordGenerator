
namespace exc.jdbi.PasswordCheckers;
internal class PasswordCheckers
{

  public const int PASSWORD_MIN_SIZE = 10;
  public const int PASSWORD_MAX_SIZE = 1024;
  internal static PasswordStrength ToPasswordStrength(string password)
  {
    AssertPasswordStrength(password);
    var sums = ToPasswordSum(password);
    var score = Math.Max(PASSWORD_MIN_SIZE, password.Length) * 4;
    Array.ForEach(sums, x => score += Math.Min(2, x) * 5);
    return score switch
    {
      < 50 => PasswordStrength.Unacceptable,
      < 60 => PasswordStrength.Weak,
      < 80 => PasswordStrength.Ok,
      < 100 => PasswordStrength.Strong,
      _ => PasswordStrength.Secure,
    };
  }

  private static int[] ToPasswordSum(string password)
  {
    var sum = new int[4];
    if (password.Count(c => 0U == (int)c) == 0)
    {
      sum[0] = password.Where(c => (int)c >= 48U && (int)c <= 57U).Count();
      sum[1] = password.Where(c => (int)c >= 64U && (int)c <= 90U).Count();
      sum[2] = password.Where(c => (int)c >= 97U && (int)c <= 122U).Count();
      sum[3] = password.Length - sum.Sum();
      return sum;
    }
    return Array.Empty<int>();
  }

  private static void AssertPasswordStrength(string password)
  {
    if (string.IsNullOrEmpty(password) ||
        password.Length < PASSWORD_MIN_SIZE ||
        password.Length > PASSWORD_MAX_SIZE)
      throw new ArgumentOutOfRangeException(nameof(password));
  }
}
