using Serilog;
using Serilog.Formatting.Json;

namespace LogsDashbord.Services;

public static class AppExcention
{
    public static void SerilogConfiguration(this IHostBuilder host)
    {
        host.UseSerilog((context,loggerConfig)=>
        {
            loggerConfig.ReadFrom.Configuration(context.Configuration);
        });
    }
}