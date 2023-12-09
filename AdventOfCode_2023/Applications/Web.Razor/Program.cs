namespace AdventOfCode_2023.Applications.Web.Razor;

public static class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();

            WebApplication app = builder.Build();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            await app.RunAsync();
        }
        catch(Exception exception)
        {
            Console.WriteLine("Main failed: {0}", exception.Message);
        }
    }
}