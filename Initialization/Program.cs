using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Dew;

public class Program
{
    public static void Main(string[] args)
    {
        new AppServices.DynamicDataGenerator().RunAndExitIf(args);

        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
        var serverUrl = $"http://0.0.0.0:{port}";

        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseUrls(serverUrl);
                
                webBuilder.UseStaticWebAssets();
                webBuilder.UseStartup<Startup>();
            })
            .ConfigureAppConfiguration((builderContext, config) =>
            {
                // Clear the default sources added by CreateDefaultBuilder so we can rebuild them WITHOUT reloadOnChange.
                config.Sources.Clear();

                // Re-add the defaults with reloadOnChange: FALSE
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);
                config.AddJsonFile("appsettings.bundles.json", optional: false, reloadOnChange: false);
                config.AddJsonFile("appsettings.machine.json", optional: true, reloadOnChange: false);

                // Keep essential providers that don't use file watchers
                config.AddEnvironmentVariables();
                config.AddCommandLine(args);
            });
    }
}