using System.Text.Json;
using System.Text.Json.Serialization;

namespace HackerNews.Integration.Connections
{
    public class HackerNewsSerialization
    {
        public static JsonSerializerOptions Options { get; set; } = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };
    }
}
