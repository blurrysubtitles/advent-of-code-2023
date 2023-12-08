public class GenericUnitOfWork<T> : BaseUnitOfWork
{
    public GenericUnitOfWork(ILogger logger) : base(logger) { }
    protected virtual Task ExecuteAsync(CancellationToken stopper) => throw new NotImplementedException();
}