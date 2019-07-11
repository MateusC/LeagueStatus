using LeagueStatus.Application.Extensions;
using LeagueStatus.SPA.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LeagueStatus.SPA.Extensions
{
    public static class ApiExtensions
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<WeatherForecastService>();

            services.AddExternalServices(configuration);
        }
    }
}
