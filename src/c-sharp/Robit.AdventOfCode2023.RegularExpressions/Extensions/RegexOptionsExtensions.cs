using System.Text.RegularExpressions;

namespace Robit.AdventOfCode2023.RegularExpressions;

public static class RegexOptionsExtensions
{
    public static RegexOptions IgnoreCaseOnly => RegexOptions.IgnoreCase;
    public static RegexOptions IgnoreCaseAndBackwardMatch => RegexOptions.IgnoreCase | RegexOptions.RightToLeft;
}