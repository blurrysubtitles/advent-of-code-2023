using System.Text.RegularExpressions;

namespace AdventOfCode_2023.Libraries.Shared.Regex;

public static class MatchExtensions
{
    public static int ParseMatch(this Match match)
        => (match.Success,
            int.TryParse(match.Value, out int wasDigit),
            Enum.TryParse(match.Value, ignoreCase: true, out NumberWord wasWord))
        switch
        {
            (false, _, _) => throw new ArgumentException($"cannot parse failed match: {nameof(match.Success)} = {match.Success}"),
            (true, true, _) => wasDigit,
            (true, _, true) => (int)wasWord,
            (_, _, _) => throw new ArgumentException($"unable to parse number word or digit to integer: {nameof(match.Value)} = {match.Value}")
        };
}