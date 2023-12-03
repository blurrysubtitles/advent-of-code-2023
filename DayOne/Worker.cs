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
            int sum = 0;

            while(cancellationToken.IsCancellationRequested is false && fileReader.EndOfStream is false)
            {
                string line = await fileReader.ReadLineAsync(cancellationToken) ?? string.Empty;
                MatchCollection matches = Regex.Matches(line, _settings.RegexPattern);
                string lineResult = string.Concat(matches.First().Value, matches.Last().Value);
                int lineValue = int.Parse(lineResult);
                sum += lineValue;
            }

            _logger.LogInformation("sum of cleaned line values = {Sum}", sum);
        }
        catch(Exception exception)
        {
            _logger.LogError("{ExceptionMessage}", exception.Message);
        }
    }
}