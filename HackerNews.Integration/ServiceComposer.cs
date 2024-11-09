using HackerNews.Integration.Connections;
using HackerNews.Integration.Interfaces;
using HackerNews.Integration.Stories;
using Microsoft.Extensions.DependencyInjection;

namespace HackerNews.Integration
{
    public static class ServiceComposer
    {
        public static IServiceCollection AddIntegration(this IServiceCollection services)
        {
            services.AddHttpClient<HackerNewsIntegration>().AddStandardResilienceHandler();
            services.AddTransient<IStoryIntegration, StoryIntegration>();

            return services;
        }
    }
}
