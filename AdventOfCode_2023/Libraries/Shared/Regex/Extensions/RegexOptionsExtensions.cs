using System.Text.RegularExpressions;

namespace AdventOfCode_2023.Libraries.Shared.Regex;

public static class RegexOptionsExtensions
{
    public static RegexOptions IgnoreCaseOnly             => RegexOptions.IgnoreCase;
    public static RegexOptions IgnoreCaseAndBackwardMatch => RegexOptions.IgnoreCase | RegexOptions.RightToLeft;
}