using AdventOfCode.Extensions;
using AdventOfCode.Models;
using Microsoft.Extensions.Options;
using System.Text.RegularExpressions;

namespace AdventOfCode.Services;

public class Day01Worker : BackgroundService
{
    private readonly Day01Settings _settings;
    private readonly ILogger<Day01Worker> _logger;

    public Day01Worker(IOptions<Day01Settings> options, ILogger<Day01Worker> logger)
        => (_settings, _logger) = (options.Value, logger);

    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        try
        {
            _logger.LogInformation("Searching {File} for matches to {RegexPattern}", _settings.InputFilePath, _settings.RegexPattern);

            using StreamReader fileReader = new(_settings.InputFilePath);
            long sum = 0;

            while(cancellationToken.IsCancellationRequested is false && fileReader.EndOfStream is false)
            {
                string line = await fileReader.ReadLineAsync(cancellationToken) ?? string.Empty;
                Match first = Regex.Match(line, _settings.RegexPattern, RegexOptions.IgnoreCase);
                Match last = Regex.Match(line, _settings.RegexPattern, RegexOptions.IgnoreCase | RegexOptions.RightToLeft);
                string lineResult = string.Concat(first.ParseMatch(), last.ParseMatch());
                sum += long.Parse(lineResult);
            }

            _logger.LogInformation("sum of cleaned line values = {Sum}", sum);
        }
        catch(Exception exception)
        {
            _logger.LogError(exception, "{ExceptionMessage}", exception.Message);
        }
    }
}