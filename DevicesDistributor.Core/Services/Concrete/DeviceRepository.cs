using DevicesDistributor.Core.Entities;
using DevicesDistributor.Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesDistributor.Core.Services.Concrete
{
    public class DeviceRepository : IDeviceRepository
    {
        private  readonly IDictionary<Guid, Device> _entities = new Dictionary<Guid, Device>();


        public  Task Add(Device device)
        {
            _entities.Add(device.Id, device);
            return Task.CompletedTask;
        }

        public Task<List<Device>> GetAllDevicesAsync()
        {

            List<Device> deviceList = _entities.Values.ToList();
            return Task.FromResult(deviceList);
        }
    }
}
