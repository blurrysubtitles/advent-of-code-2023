using AdventOfCode_2023.Libraries.Days.Day_01;
using AdventOfCode_2023.Libraries.Shared.DependencyInjection;

namespace AdventOfCode_2023.Applications.Worker;

public static class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddWorker<AdventOfCode_2023.Libraries.Days.Day_01.Worker>();
            builder.Services.AddWorker<AdventOfCode_2023.Libraries.Days.Day_02.Worker>();
            await builder.Build().RunAsync();
        }
        catch(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}