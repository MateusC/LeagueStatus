using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace LeagueStatus.Data.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddPersistence(this IServiceCollection services)
        {
            services.AddStorage();

            services.AddScoped<IStorage, Storage>();
        }
    }
}
