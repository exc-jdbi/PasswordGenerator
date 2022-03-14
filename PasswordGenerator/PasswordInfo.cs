namespace exc.jdbi.PasswordGenerators;

using exc.jdbi.Converts;

/// <summary>
/// Password Infos
/// </summary>
public class PasswordInfo
{
  public int Length;
  public bool NumericLetters;
  public bool LowercaseCharacters;
  public bool UppercaseCharacters;
  public bool SpecialCharacters;
  public bool InternationalSymbols;
  public StringConvertInfo StringConvertInfo;
}
