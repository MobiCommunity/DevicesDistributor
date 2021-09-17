using DevicesDistributor.Core.Entities;
using DevicesDistributor.Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevicesDistributor.Core.Services.Concrete
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;

        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }
        async Task<IEnumerable<Device>> IDeviceService.GetAllAsync() => await _deviceRepository.GetAll();
        async Task<Device> IDeviceService.GetAsync(Guid id) => await _deviceRepository.Get(id);
        async Task IDeviceService.AddAsync(Device device) => await _deviceRepository.Add(device);
    }
}
