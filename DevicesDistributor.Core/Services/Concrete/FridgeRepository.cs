using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevicesDistributor.Core.Entities;
using DevicesDistributor.Core.Services.Abstract;

namespace DevicesDistributor.Core.Services.Concrete
{
    public class FridgeRepository : IFridgeRepository
    {
        private readonly IDictionary<Guid,Fridge> _entities = new Dictionary<Guid,Fridge>();
        public Task<Fridge> Get(Guid id)
        {
            Fridge fridgeResult = _entities.TryGetValue(id,out Fridge fridge) ? fridge : null;

            return Task.FromResult(fridgeResult);
        }

        public Task Add(Fridge fridge)
        {
            _entities.Add(fridge.Id,fridge);
            return Task.CompletedTask;
        }
    }
}