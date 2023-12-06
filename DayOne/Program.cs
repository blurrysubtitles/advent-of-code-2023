using AdventOfCode.Extensions;

namespace AdventOfCode;

public static class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddDayOneWorker();
            await builder.Build().RunAsync();
        }
        catch(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}