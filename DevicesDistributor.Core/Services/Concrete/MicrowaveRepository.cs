using DevicesDistributor.Core.Entities;
using DevicesDistributor.Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevicesDistributor.Core.Services.Concrete
{
    public class MicrowaveRepository : IMicrowaveRepository
    {

        private readonly IDictionary<Guid, Microwave> _entities = new Dictionary<Guid, Microwave>();
        public Task Add(Microwave microwave)
        {
            _entities.Add(microwave.Id, microwave);
            return Task.CompletedTask;
        }
    }
}
