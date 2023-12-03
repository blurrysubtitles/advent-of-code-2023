namespace DayOne;

public class WorkerSettings
{
    public string InputFilePath {get; set; } = "./Content/input.txt";

    public string RegexPattern { get; set; } = $"({RegexDigitsOrNumberWords})";

    private enum NumberWord
    {
        Zero  = 0,
        One   = 1,
        Two   = 2,
        Three = 3,
        Four  = 4,
        Five  = 5,
        Six   = 6,
        Seven = 7,
        Eight = 8,
        Nine  = 9
    }
    private static string RegexDigit       => @"\d";
    private static string RegexAlternation => "|";
    private static string RegexDigitsOrNumberWords
        => Enum.GetNames<NumberWord>()
        .Select(name => name.ToLower())
        .Append(RegexDigit)
        .Aggregate((accumulator, current) => string.Join(RegexAlternation, accumulator, current));
}