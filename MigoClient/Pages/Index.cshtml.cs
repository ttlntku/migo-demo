using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MigoClient.Services;
using MigoService;

namespace MigoClient.Pages
{
    public class IndexModel : PageModel
    {
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
            var client = new Greeter.GreeterClient(channel);
            WelcomeMessage = client.SayHello(new HelloRequest { Name = "KIEU"}).Message;
        }
    }
}
