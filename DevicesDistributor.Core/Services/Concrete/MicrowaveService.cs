using DevicesDistributor.Core.Entities;
using DevicesDistributor.Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevicesDistributor.Core.Services.Concrete
{
    public class MicrowaveService : IMicrowaveService
    {
        private readonly ISerialNumberProviderClient _serialNumberProviderClient;
        private readonly IDeviceRepository _deviceRepository;

        public MicrowaveService(ISerialNumberProviderClient serialNumberProviderClient, IDeviceRepository deviceRepository)
        {
            _serialNumberProviderClient = serialNumberProviderClient;
            _deviceRepository = deviceRepository;
        }
        public async Task AddAsync(Guid id, string name, string version, DateTime productionDate)
        {
            string generated = await _serialNumberProviderClient.GenerateAsyncMD5(new GenerateSerialNumberRequest(id, name, version, productionDate));
            Microwave microwave = Microwave.Create(id, name, version, productionDate, generated);
            await _deviceRepository.Add(microwave);
        }
    }
}
