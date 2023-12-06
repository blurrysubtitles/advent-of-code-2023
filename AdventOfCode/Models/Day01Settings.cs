using AdventOfCode.Extensions;

namespace AdventOfCode.Models;

public class Day01Settings
{
    public static readonly string Name = nameof(Day01Settings);

    public string InputFilePath { get; set; } = "./Content/01/input.txt";
    public string RegexPattern  { get; set; } = RegexExtensions.DigitOrNumberWordPattern;
}