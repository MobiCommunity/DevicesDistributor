using System.Threading.Tasks;

namespace DevicesDistributor.Core.Services.Abstract
{
    public interface ISerialNumberProviderClient
    {
        Task<string> GenerateAsync(GenerateSerialNumberRequest request);
    }
}