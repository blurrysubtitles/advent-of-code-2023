using System.Text.RegularExpressions;

namespace Robit.Libraries.CSharp.RegularExpressions;

public static class RegexOptionsExtensions
{
    public static RegexOptions IgnoreCaseOnly => RegexOptions.IgnoreCase;
    public static RegexOptions IgnoreCaseAndBackwardMatch => RegexOptions.IgnoreCase | RegexOptions.RightToLeft;
}