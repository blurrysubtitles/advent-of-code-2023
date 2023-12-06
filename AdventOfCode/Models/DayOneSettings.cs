using AdventOfCode.Extensions;

namespace AdventOfCode.Models;

public class DayOneSettings
{
    public static readonly string Name = nameof(DayOneSettings);

    public string InputFilePath { get; set; } = "./Content/input.txt";
    public string RegexPattern  { get; set; } = RegexExtensions.DigitOrNumberWordPattern;
}