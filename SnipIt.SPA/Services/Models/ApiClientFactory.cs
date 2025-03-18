using SnipIt.SPA.Services.Interfaces;

namespace SnipIt.SPA.Services.Models
{
    public class ApiClientFactory : IApiClientFactory
    {
        public HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("API-X", "");
            return client;
        }
    }
}
