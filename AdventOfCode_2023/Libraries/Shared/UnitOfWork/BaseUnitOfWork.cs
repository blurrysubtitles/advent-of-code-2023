public abstract class BaseUnitOfWork : BackgroundService, IUnitOfWork
{
    private readonly ILogger _logger;
    public BaseUnitOfWork(ILogger logger) => _logger = logger;
    protected abstract Task ExecuteAsync(CancellationToken stopper);
}