using AdventOfCode_2023.Libraries.Shared.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace AdventOfCode_2023.Libraries.Days.Day_02;

public static class ExtensionsDay_02
{
    public static IServiceCollection AddWorkerDay_02(this IServiceCollection services) => services.AddWorker<Worker>();
}