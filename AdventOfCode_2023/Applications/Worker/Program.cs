namespace AdventOfCode_2023.Applications.Worker;

public static class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddWorkerDay_01();
            builder.Services.AddWorkerDay_01();
            await builder.Build().RunAsync();
        }
        catch(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}