using Robit.AdventOfCode2023.RegularExpressions;

namespace Robit.AdventOfCode2023.Day_01;

public class Settings
{
    public static readonly string Name = nameof(Settings);

    public string InputFilePath { get; set; } = "./Content/01/input.txt";
    public string RegexPattern { get; set; } = RegexExtensions.DigitOrNumberWordPattern;
}