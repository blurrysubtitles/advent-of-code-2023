using AdventOfCode_2023.Libraries.Shared.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace AdventOfCode_2023.Libraries.Days.Day_01;

public static class ExtensionsDay_01
{
    public static IServiceCollection AddWorkerDay_01(this IServiceCollection services) => services.AddWorker<Worker>();
}