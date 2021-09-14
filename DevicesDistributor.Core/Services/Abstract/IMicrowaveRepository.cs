using DevicesDistributor.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevicesDistributor.Core.Services.Abstract
{
    public interface IMicrowaveRepository
    {
        Task Add(Microwave microwave);
    }
}
