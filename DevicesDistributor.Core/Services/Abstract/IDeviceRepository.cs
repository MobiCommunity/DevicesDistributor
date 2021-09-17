using DevicesDistributor.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevicesDistributor.Core.Services.Abstract
{
    public interface IDeviceRepository
    {
        Task<IEnumerable<Device>> GetAll();
        Task Add(Device device);
        Task<Device> Get(Guid id);
    }
}
