using MigoClient.Configs;

namespace MigoClient.Services
{
    public interface IPersistenceFactory
    {
        GrpcConfig GetGrpcConfig();
    }
}
