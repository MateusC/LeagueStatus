using LeagueStatus.Application.Services.Summoner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LeagueStatus.Application.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddExternalServices(this IServiceCollection services, IConfiguration configuration)
        {
            ApiSettings settings = new ApiSettings();
            configuration.Bind(settings);

            services.AddSingleton<ISummonerService>(_ => new SummonerService(settings));
        }
    }
}
