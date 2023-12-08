using Microsoft.Extensions.Logging;

namespace AdventOfCode_2023.Libraries.Shared.UnitOfWork;

public class GenericUnitOfWork : BaseUnitOfWork
{
    private readonly Func<CancellationToken, Task> _tryAction;
    private readonly Action<Exception> _catchAction;

    public GenericUnitOfWork(Func<CancellationToken, Task> tryAction, Action<Exception> catchAction, ILogger logger)
        : base(logger) => (_tryAction, _catchAction) = (tryAction, catchAction);

    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        try
        {
            await _tryAction.Invoke(cancellationToken);
        }
        catch(Exception exception)
        {
            _catchAction.Invoke(exception);
        }
    }
}