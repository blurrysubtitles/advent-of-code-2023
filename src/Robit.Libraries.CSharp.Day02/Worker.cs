using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.RegularExpressions;

namespace Robit.Libraries.CSharp.Day02;

public class Worker : BackgroundService
{
    private readonly Settings _settings;
    private readonly ILogger<Worker> _logger;

    public Worker(IOptions<Settings> options, ILogger<Worker> logger) => (_settings, _logger) = (options.Value, logger);

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
                string lineWithoutWhitespace = Regex.Replace(line, @"\s", string.Empty);
                string[] gameSamples = line.Split(":");
                string gameNumber = gameSamples[0];
                string samples = gameSamples[1];
                string[] sampleGroups = samples.Split(";");
            }

            _logger.LogInformation("sum of ids of possible games = {Sum}", sum);
        }
        catch(Exception exception)
        {
            _logger.LogError(exception, "{ExceptionMessage}", exception.Message);
        }
    }
}