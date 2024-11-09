
namespace HackerNews.Integration.Connections
{
    public class HackerNewsIntegration
    {
        public HttpClient Http { get; }

        public HackerNewsIntegration(HttpClient httpClient)
        {
            httpClient.BaseAddress ??= new Uri(HackerNewsUrl.API);

            Http = httpClient;
        }
    }
}
