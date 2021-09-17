using System;
using System.Threading.Tasks;
using DevicesDistributor.Core.Entities;
using DevicesDistributor.Core.Services.Abstract;

namespace DevicesDistributor.Core.Services.Concrete
{
    public class FridgeService : IFridgeService
    {
        private readonly ISerialNumberProviderClient _serialNumberProviderClient;
        private readonly IFridgeRepository _fridgeRepository;
        private readonly IDeviceRepository _deviceRepository;

        public FridgeService(IFridgeRepository fridgeRepository, ISerialNumberProviderClient serialNumberProviderClient, IDeviceRepository deviceRepository)
        {
            _fridgeRepository = fridgeRepository;
            _deviceRepository = deviceRepository;
            _serialNumberProviderClient = serialNumberProviderClient;
        }

        public async Task AddAsync(Guid id, string name, string version, DateTime productionDate)
        {
            string generated = await _serialNumberProviderClient.GenerateAsync(
                new GenerateSerialNumberRequest(id, name, version, productionDate));

            Fridge fridge = Fridge.Create(id, name, version, productionDate, generated);
            await _deviceRepository.Add(fridge);

        }
    }
}