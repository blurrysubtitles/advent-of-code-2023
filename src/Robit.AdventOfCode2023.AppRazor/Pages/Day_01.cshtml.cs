using Microsoft.AspNetCore.Mvc.RazorPages;
using Robit.AdventOfCode2023.RegularExpressions;
using System.Text.RegularExpressions;

namespace Web.Razor.Pages;

public class Day_01Model(ILogger<Day_01Model> logger, [FromKeyedServices(Day_01Model._serviceKey)] StreamReader inputfileReader) : PageModel
{
    private const string _serviceKey = "Day_01/input.txt";
    private static readonly string _regexPattern = RegexExtensions.DigitOrNumberWordPattern;

    private readonly ILogger<Day_01Model> _logger = logger;
    private readonly StreamReader _inputFileReader = inputfileReader;

    public long ResultSum { get; private set; } = 0;
    public List<string> ServiceKeys { get; private set; } = [];

    public async Task OnGetAsync(CancellationToken cancellationToken)
    {
        try
        {
            _logger.LogInformation("Searching {File} for matches to {RegexPattern}", _serviceKey, _regexPattern);

            while(cancellationToken.IsCancellationRequested is false && _inputFileReader.EndOfStream is false)
            {
                string line = await _inputFileReader.ReadLineAsync(cancellationToken) ?? string.Empty;
                Match first = Regex.Match(line, _regexPattern, RegexOptions.IgnoreCase);
                Match last = Regex.Match(line, _regexPattern, RegexOptions.IgnoreCase | RegexOptions.RightToLeft);
                string lineResult = string.Concat(first.ParseMatch(), last.ParseMatch());
                ResultSum += long.Parse(lineResult);
            }

            _logger.LogInformation("sum of cleaned line values = {Sum}", ResultSum);
        }
        catch(Exception exception)
        {
            _logger.LogError(exception, "{ExceptionMessage}", exception.Message);
        }
    }
}