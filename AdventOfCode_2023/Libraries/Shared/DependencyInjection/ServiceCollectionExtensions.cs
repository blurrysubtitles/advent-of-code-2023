using AdventOfCode_2023.Libraries.Shared.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace AdventOfCode_2023.Libraries.Shared.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void AddWorker<TUnitOfWork>(this IServiceCollection services) where TUnitOfWork : BaseUnitOfWork
        => services
        .AddHostedService<TUnitOfWork>();
}