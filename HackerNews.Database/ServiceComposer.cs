using HackerNews.Database.Connections;
using HackerNews.Database.Interfaces;
using HackerNews.Database.Sets;
using HackerNews.Database.Stories;
using Microsoft.Extensions.DependencyInjection;

namespace HackerNews.Database
{
    public static class ServiceComposer
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            services.AddTransient<HackerNewsConnection>();
            services.AddTransient<HackerNewsContext>();
            services.AddTransient<IDb, Db>();
            services.AddTransient<IStoryDb, StoryDb>();

            return services;
        }
    }
}
