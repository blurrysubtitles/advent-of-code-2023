public static class ServiceCollectionExtensions
{
    public static void AddDay01Worker(this IServiceCollection services)
        => services
        .AddHostedService<Day01Worker>()
        .AddOptions<Day01Settings>()
        .BindConfiguration(Day01Settings.Name)
        .ValidateDataAnnotations()
        .ValidateOnStart();
}