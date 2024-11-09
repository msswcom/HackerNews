using HackerNews.Database;
using HackerNews.Integration;
using HackerNews.Orchestration.Interfaces;
using HackerNews.Orchestration.Stories;
using Microsoft.Extensions.DependencyInjection;

namespace HackerNews.Orchestration
{
    public static class ServiceComposer
    {
        public static IServiceCollection AddOrchestration(this IServiceCollection services)
        {
            services.AddDatabase();
            services.AddIntegration();
            services.AddTransient<IStoryOrchestration, StoryOrchestration>();

            return services;
        }
    }
}
