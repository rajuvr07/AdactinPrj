using Insurance.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Insurance.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.TryAddSingleton<IPremiumService, PremiumService>();
            services.TryAddSingleton<IRatingService, RatingService>();
        }
    }
}
