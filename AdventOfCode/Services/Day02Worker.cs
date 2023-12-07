using AdventOfCode.Models;
using Microsoft.Extensions.Options;

namespace AdventOfCode.Services;

public class Day02Worker : BackgroundService
{
    private readonly Day02Settings _settings;
    private readonly ILogger<Day02Worker> _logger;

    public Day02Worker(IOptions<Day02Settings> options, ILogger<Day02Worker> logger)
        => (_settings, _logger) = (options.Value, logger);

    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        try
        {
            _logger.LogInformation("Searching {File}", _settings.InputFilePath);

            using StreamReader fileReader = new(_settings.InputFilePath);
            long sum = 0;

            while(cancellationToken.IsCancellationRequested is false && fileReader.EndOfStream is false)
            {
                string line = (await fileReader.ReadLineAsync(cancellationToken)) ?? string.Empty;
                string[] gameSamples = line.Split(":");
                string gameNumber = gameSamples[0];
                string samples = gameSamples[1];
                string[]
            }

            _logger.LogInformation("sum of ids of possible games = {Sum}", sum);
        }
        catch(Exception exception)
        {
            _logger.LogError(exception, "{ExceptionMessage}", exception.Message);
        }
    }
}