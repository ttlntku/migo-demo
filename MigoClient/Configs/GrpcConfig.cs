namespace MigoClient.Configs
{
    public class GrpcConfig
    {
        public string AddressUrl { get; set; }
        public GrpcConfig(string addressUrl)
        {
            AddressUrl = addressUrl;
        }

        public void Dispose()
        {
            //do nothing
        }
    }
}
