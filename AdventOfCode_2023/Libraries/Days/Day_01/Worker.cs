using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.RegularExpressions;

public class Worker : BaseUnitOfWork
{
    private readonly Settings _settings;

    public Worker(IOptions<Settings> options, ILogger<Worker> logger) : base(logger) => _settings = options.Value;

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