using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void AddWorker<TUnitOfWork>(this IServiceCollection services) where TUnitOfWork : BaseUnitOfWork
        => services
        .AddHostedService<TUnitOfWork>();
}