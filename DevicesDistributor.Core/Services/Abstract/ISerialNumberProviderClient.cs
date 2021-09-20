using System.Threading.Tasks;

namespace DevicesDistributor.Core.Services.Abstract
{
    public interface ISerialNumberProviderClient
    {
        Task<string> GenerateAsyncSHA256(GenerateSerialNumberRequest request);
        Task<string> GenerateAsyncMD5(GenerateSerialNumberRequest request);
    }
}