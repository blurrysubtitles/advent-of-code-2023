using Microsoft.Extensions.Logging;

public class GenericUnitOfWork<T> : BaseUnitOfWork
{
    public GenericUnitOfWork(ILogger logger) : base(logger) { }
    protected override Task ExecuteAsync(CancellationToken stopper) => throw new NotImplementedException();
}