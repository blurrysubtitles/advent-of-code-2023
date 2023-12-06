using AdventOfCode.Models;
using AdventOfCode.Services;

namespace AdventOfCode.Extensions;

public static class DependencyInjectionExtensions
{
    public static void AddDay01Worker(this IServiceCollection services)
        => services
        .AddHostedService<Day01Worker>()
        .AddOptions<Day01Settings>()
        .BindConfiguration(Day01Settings.Name)
        .ValidateDataAnnotations()
        .ValidateOnStart();
}