using HackerNews.API.Background;
using HackerNews.Orchestration;

namespace HackerNews.API
{
    public static class ServiceComposer
    {
        public static IServiceCollection AddAPI(this IServiceCollection services)
        {
            services.AddOrchestration();
            services.AddHostedService<BackgroundUpdateBestStories>();

            return services;
        }
    }
}
