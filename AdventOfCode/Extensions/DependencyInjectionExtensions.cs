using AdventOfCode.Models;
using AdventOfCode.Services;

namespace AdventOfCode.Extensions;

public static class DependencyInjectionExtensions
{
    public static void AddDayOneWorker(this IServiceCollection services)
        => services
        .AddHostedService<DayOneWorker>()
        .AddOptions<DayOneSettings>()
        .BindConfiguration(DayOneSettings.Name)
        .ValidateDataAnnotations()
        .ValidateOnStart();
}