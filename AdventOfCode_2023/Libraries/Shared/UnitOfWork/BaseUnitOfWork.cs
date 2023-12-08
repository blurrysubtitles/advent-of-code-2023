using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public abstract class BaseUnitOfWork : BackgroundService, IUnitOfWork
{
    protected readonly ILogger _logger;
    public BaseUnitOfWork(ILogger logger) => _logger = logger;
}