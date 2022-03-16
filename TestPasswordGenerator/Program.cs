

using System.Text;

namespace exc.jdbi.Tests;
using exc.jdbi.Converts;
using exc.jdbi.PasswordGenerators;
using static exc.jdbi.PasswordGenerators.PasswordGenerator;

public class Program
{
  private static readonly Random Rand = new();
  private static Encoding OutputEncoding = Encoding.UTF8; 
  public static void Main()
  { 

    //Console UniCode-Output
    SetConsoleOutputEncoding(true);

    TestCreatePassword();
    TestFullRngCreatePassword();

    SetConsoleOutputEncoding(false);

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("FINISH");
    Console.ReadLine();
  }


  private static void TestCreatePassword()
  {
    Console.WriteLine($"{nameof(TestCreatePassword)} (Default)");
    Console.WriteLine($"****************************");
    Console.WriteLine();

    var count = 10;
    for (int i = 0; i < count; i++)
    {
      var size = Rand.Next(10, 32);
      PasswordInfo pwinfo = DefaultPasswordInfo(size);
      PrintOut(pwinfo);
      var pw = PasswordString(pwinfo);
      var originalpw = DecodePassword(pw, pwinfo.StringConvertInfo);
      var pwstrength = PasswordStrengthChecker(originalpw);
      Console.WriteLine($"Password original: {originalpw }");
      Console.WriteLine($"Password encoded: {pw}");
      Console.WriteLine($"Strength: {pwstrength}");
      Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
  }

  private static void TestFullRngCreatePassword()
  {
    Console.WriteLine($"{nameof(TestFullRngCreatePassword)} ");
    Console.WriteLine($"*************************");
    Console.WriteLine();

    var count = 10;
    for (int i = 0; i < count; i++)
    {
      PasswordInfo pwinfo = RngPasswordInfo();
      PrintOut(pwinfo);
      var pw = PasswordString(pwinfo);
      var originalpw = DecodePassword(pw, pwinfo.StringConvertInfo);
      var pwstrength = PasswordStrengthChecker(originalpw);
      Console.WriteLine($"Password original: {originalpw }");
      Console.WriteLine($"Password encoded: {pw}");
      Console.WriteLine($"Strength: {pwstrength}");
      Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
  }
   
  private static PasswordInfo DefaultPasswordInfo(int size)
  {
    PasswordInfo pwinfo = new();
    pwinfo.Length = size;
    pwinfo.NumericLetters = true;
    pwinfo.UppercaseCharacters = true;
    pwinfo.LowercaseCharacters = true;
    pwinfo.SpecialCharacters = false;
    pwinfo.InternationalSymbols = false;
    return pwinfo;
  }

  private static PasswordInfo V1PasswordInfo(int size)
  {
    PasswordInfo pwinfo = new();
    pwinfo.Length = size;
    pwinfo.NumericLetters = true;
    pwinfo.UppercaseCharacters = true;
    pwinfo.LowercaseCharacters = true;
    pwinfo.SpecialCharacters = true;
    pwinfo.InternationalSymbols = false;
    return pwinfo;
  }

  private static PasswordInfo V2PasswordInfo(int size)
  {
    PasswordInfo pwinfo = new();
    pwinfo.Length = size;
    pwinfo.NumericLetters = true;
    pwinfo.UppercaseCharacters = true;
    pwinfo.LowercaseCharacters = true;
    pwinfo.SpecialCharacters = true;
    pwinfo.InternationalSymbols = true;
    return pwinfo;
  }

  private static PasswordInfo RngPasswordInfo()
  {
    var cnt = 0;
    PasswordInfo pwinfo = new();
    var enums = (StringConvertInfo[])Enum.GetValues(typeof(StringConvertInfo));
    while (cnt <= 0)
    {
      cnt = 0;
      pwinfo.Length = Rand.Next(10, 32);
      pwinfo.NumericLetters = Rand.Next(0, 2) == 1;
      if (pwinfo.NumericLetters) cnt++;
      pwinfo.UppercaseCharacters = Rand.Next(0, 2) == 1;
      if (pwinfo.UppercaseCharacters) cnt++;
      pwinfo.LowercaseCharacters = Rand.Next(0, 2) == 1;
      if (pwinfo.LowercaseCharacters) cnt++;
      pwinfo.SpecialCharacters = Rand.Next(0, 2) == 1;
      if (pwinfo.SpecialCharacters) cnt++;
      pwinfo.InternationalSymbols = Rand.Next(0, 2) == 1;
      if (pwinfo.InternationalSymbols) cnt++;
      pwinfo.StringConvertInfo = enums[Rand.Next(enums.Length)];
    }
    return pwinfo;
  }


  private static void PrintOut(PasswordInfo pwinfo)
  {
    Console.WriteLine($"Length = {pwinfo.Length}");
    Console.WriteLine($"NumericLetters = {pwinfo.NumericLetters}");
    Console.WriteLine($"LowercaseCharacters = {pwinfo.LowercaseCharacters}");
    Console.WriteLine($"UppercaseCharacters = {pwinfo.UppercaseCharacters}");
    Console.WriteLine($"SpecialCharacters = {pwinfo.SpecialCharacters}");
    Console.WriteLine($"InternationalSymbols = {pwinfo.InternationalSymbols}");
    Console.WriteLine($"StringConvertInfo = {pwinfo.StringConvertInfo}");
  }

  private static void SetConsoleOutputEncoding(bool _set)
  {
    //Ist nur eine provisorische Lösung.
    if (_set)
    {
      //https://stackoverflow.com/a/5750227
      OutputEncoding = Console.OutputEncoding;
      Console.OutputEncoding = Encoding.UTF8;
      return;
    }
    Console.OutputEncoding = OutputEncoding;
  }


  //private static void TestCRandom()
  //{
  //  for (int j = 0; j < 10000; j++)
  //  {
  //    var count = 1000;
  //    var ints = new int[count];
  //    for (int i = 0; i < count; i++)
  //      ints[i] = CRand.Next(2);

  //    var result = new int[3];
  //    result[0] = ints.Where(x => x == 0).Count();
  //    result[1] = ints.Where(x => x == 1).Count();
  //    result[2] = count - result.Sum();
  //    if (result[2] != 0)
  //      Debugger.Break(); 

  //    if (count/2.0 * .85 >= result[0])
  //      Debugger.Break();

  //    if (count / 2.0 * .85 >= result[1])
  //      Debugger.Break();
  //  }
  //}

}