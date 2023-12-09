using AdventOfCode_2023.Libraries.Days.Day_02;
using AdventOfCode_2023.Libraries.Shared.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection;

public static class ExtensionsDay_02
{
    public static IServiceCollection AddWorkerDay_02(this IServiceCollection services) => services.AddWorker<Worker>();
}