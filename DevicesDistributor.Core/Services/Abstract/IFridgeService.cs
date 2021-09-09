using System;
using System.Threading.Tasks;
using DevicesDistributor.Core.Entities;

namespace DevicesDistributor.Core.Services.Abstract
{
    public interface IFridgeService
    {
        Task AddAsync(Guid id, string name, string version, DateTime productionDate);
        Task<Fridge> GetAsync(Guid id);
    }
}