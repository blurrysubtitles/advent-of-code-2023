using AdventOfCode_2023.Libraries.Days.Day_01;
using AdventOfCode_2023.Libraries.Shared.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection;

public static class ExtensionsDay_01
{
    public static IServiceCollection AddWorkerDay_01(this IServiceCollection services) => services.AddWorker<Worker>();
}