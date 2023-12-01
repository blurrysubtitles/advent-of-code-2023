using Microsoft.Extensions.Options;
using System.Text.RegularExpressions;

namespace DayOne;

public class Worker : BackgroundService
{
    private readonly WorkerSettings _settings;
    private readonly ILogger<Worker> _logger;

    public Worker(IOptions<WorkerSettings> options, ILogger<Worker> logger)
        => (_settings, _logger) = (options.Value, logger);

    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        try
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            using StreamReader fileReader = new(_settings.InputFilePath);
            int lineCount = 0;

            while(cancellationToken.IsCancellationRequested is false
                && fileReader.EndOfStream is false)
            {
                string line = await fileReader.ReadLineAsync(cancellationToken) ?? string.Empty;
                lineCount++;
                MatchCollection matches = Regex.Matches(line, _settings.SingleDigitRegexPattern);

                if(matches.Count == 0)
                {
                    _logger.LogWarning($"no matches found on line {lineCount}");
                }
                else
                {
                    string firstDigit = matches.First().Value;
                    string lastDigit = matches.Last().Value;
                    string lineResult = string.Concat(firstDigit, lastDigit);
                    _logger.LogInformation($"{nameof(lineCount)}={lineCount} :: {nameof(lineResult)}={lineResult}");
                }
            }
        }
        catch(Exception exception)
        {
            _logger.LogError(exception.Message);
        }
    }
}