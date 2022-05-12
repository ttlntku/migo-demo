using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MigoClient.Services;

namespace MigoClient.Pages
{
    public class IndexModel : PageModel
    {
        public Stories stories;
        public Topics topics;
        private readonly ILogger<IndexModel> _logger;
        private readonly IPersistenceFactory _persistenceFactory;
        public string WelcomeMessage;
        public IndexModel(ILogger<IndexModel> logger, IPersistenceFactory persistenceFactory)
        {
            _logger = logger;
            _persistenceFactory = persistenceFactory;
        }

        public void OnGet()
        {
            var channel = GrpcChannel.ForAddress(_persistenceFactory.GetGrpcConfig().AddressUrl);
            var client = new StoryFunc.StoryFuncClient(channel);
            stories = client.GetAllStory(new EmptyStory());

            var client2 = new TopicFunc.TopicFuncClient(channel);
            topics = client2.GetAllTopic(new EmptyTopic());
        }
    }
}
