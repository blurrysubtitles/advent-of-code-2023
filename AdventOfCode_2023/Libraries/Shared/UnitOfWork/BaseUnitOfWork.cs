using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public abstract class BaseUnitOfWork : BackgroundService, IUnitOfWork
{
    private readonly ILogger _logger;
    public BaseUnitOfWork(ILogger logger) => _logger = logger;
}