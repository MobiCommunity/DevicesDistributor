using System;
using System.Threading.Tasks;
using DevicesDistributor.Core.Entities;

namespace DevicesDistributor.Core.Services.Abstract
{
    public interface IFridgeRepository
    {
        Task<Fridge> Get(Guid id);
        Task Add(Fridge fridge);
   
    }
}