namespace DayOne;

public static class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddHostedService<Worker>();

            IHost host = builder.Build();
            host.Run();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}
