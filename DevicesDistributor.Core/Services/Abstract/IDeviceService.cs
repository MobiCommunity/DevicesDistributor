using DevicesDistributor.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevicesDistributor.Core.Services.Abstract
{
    public interface IDeviceService
    {
        public Task<IEnumerable<Device>> GetAllAsync();
        public Task AddAsync(Device device);
        public Task<Device> GetAsync(Guid id);
    }
}
