using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AdventOfCode_2023.Libraries.Shared.UnitOfWork;

public abstract class BaseUnitOfWork : BackgroundService, IUnitOfWork
{
    protected readonly ILogger _logger;
    public BaseUnitOfWork(ILogger logger) => _logger = logger;
}