using MigoClient.Configs;

namespace MigoClient.Services
{
    public class PersistenceFactory : IPersistenceFactory
    {
        public GrpcConfig GrpcConfig { get; set; }
        public PersistenceFactory(GrpcConfig grpcConfig)
        {
            GrpcConfig = grpcConfig;
        }

        public GrpcConfig GetGrpcConfig()
        {
            return GrpcConfig;
        }
    }
}
