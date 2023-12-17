using Microsoft.Extensions.Logging.Console;

namespace AdventOfCode_2023.Applications.Web.Razor;

public static class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            WebApplicationBuilder builder =
                WebApplication
                .CreateSlimBuilder(args);

            WebApplication app =
                builder
                .Logging.AddSimpleConsole(_configureSimpleConsoleFormatterOptions).Return(builder)
                .Services.AddRazorPages().Return(builder)
                .Build();

            Task mainTask =
                app
                .UseHttpsRedirection()
                .UseStaticFiles()
                .UseRouting()
                .UseAuthorization().Return(app)
                .MapRazorPages().Return(app)
                .RunAsync();

            await mainTask;
        }
        catch(Exception exception)
        {
            Console.WriteLine("Main failed: {0}", exception.Message);
        }
    }

    static Action<SimpleConsoleFormatterOptions> _configureSimpleConsoleFormatterOptions = options =>
        options
        .Mutate(o => o.IncludeScopes = true)
        .Mutate(o => o.SingleLine = true)
        .ReturnVoid();

    static TReturned Return<TExtended, TReturned>(
        this TExtended _,
        TReturned result)
        => result;

    static void ReturnVoid<TExtended>(
        this TExtended _)
        { }

    static T Mutate<T>(this T result, Action<T> action) where T : class
    {
        action.Invoke(result);
        return result;
    }
}