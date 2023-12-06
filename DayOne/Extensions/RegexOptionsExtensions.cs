using System.Text.RegularExpressions;

namespace AdventOfCode.Extensions;

public static class RegexOptionsExtensions
{
    public static RegexOptions IgnoreCaseOnly             => RegexOptions.IgnoreCase;
    public static RegexOptions IgnoreCaseAndBackwardMatch => RegexOptions.IgnoreCase | RegexOptions.RightToLeft;
}