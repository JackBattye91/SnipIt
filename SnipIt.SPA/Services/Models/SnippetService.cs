using SnipIt.SPA.Services.Interfaces;

namespace SnipIt.SPA.Services.Models
{
    public class SnippetService : ISnippetService
    {
        private readonly ILogger<SnippetService> _logger;
        private readonly HttpClient _apiClient;

        public SnippetService(ILogger<SnippetService> logger, IHttpClientFactory clientFactory) 
        { 
            _logger = logger;
            _apiClient = clientFactory.CreateClient("api");
        }

    }
}
