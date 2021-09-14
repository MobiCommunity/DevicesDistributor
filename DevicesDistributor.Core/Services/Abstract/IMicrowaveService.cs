using DevicesDistributor.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevicesDistributor.Core.Services.Abstract
{
    public interface IMicrowaveService
    {
        Task AddAsync(Guid id, string name, string version, DateTime productionDate);
  
    }
}
