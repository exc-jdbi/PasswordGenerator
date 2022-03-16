

namespace exc.jdbi.PasswordCheckers;
internal sealed class ArrayEqualityComparer : IEqualityComparer<int[]>
{
#pragma warning disable CS8767 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem implizit implementierten Member.
  public bool Equals(int[] x, int[] y)
  => x.SequenceEqual(y);

  public int GetHashCode(int[] obj)
  {
    int result = 17;
    for (int i = 0; i < obj.Length; i++)
      unchecked
      {
        result = result * 23 + obj[i];
      }
    return result;
  }


#pragma warning restore CS8767 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem implizit implementierten Member.

}