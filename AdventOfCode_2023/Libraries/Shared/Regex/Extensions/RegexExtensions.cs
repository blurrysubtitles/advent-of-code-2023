namespace AdventOfCode_2023.Libraries.Shared.Regex;

public static class RegexExtensions
{
    public static string AlternationOperator => "|";

    public static string DigitPattern => @"\d";
    public static string DigitOrNumberWordPattern
        => Enum.GetNames<NumberWord>()
        .Select(name => name.ToLower())
        .Append(DigitPattern)
        .Aggregate((accumulator, current) => string.Join(AlternationOperator, accumulator, current));
}