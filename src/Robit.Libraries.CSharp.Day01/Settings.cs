using Robit.Libraries.CSharp.RegularExpressions;

namespace Robit.Libraries.CSharp.Day01;

public class Settings
{
    public static readonly string Name = nameof(Settings);

    public string InputFilePath { get; set; } = "./Content/01/input.txt";
    public string RegexPattern { get; set; } = RegexExtensions.DigitOrNumberWordPattern;
}