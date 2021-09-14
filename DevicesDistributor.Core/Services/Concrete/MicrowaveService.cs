﻿using DevicesDistributor.Core.Entities;
using DevicesDistributor.Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevicesDistributor.Core.Services.Concrete
{
    public class MicrowaveService : IMicrowaveService
    {
        private readonly ISerialNumberProviderClient _serialNumberProviderClient;
        private readonly IMicrowaveRepository _microvaweRepository;
        private readonly IDeviceRepository _deviceRepository;


        public MicrowaveService(ISerialNumberProviderClient serialNumberProviderClient, IMicrowaveRepository microwaveRepository, IDeviceRepository deviceRepository)
        {
            _serialNumberProviderClient = serialNumberProviderClient;
            _microvaweRepository = microwaveRepository;
            _deviceRepository = deviceRepository;
        }

        public async Task AddAsync(Guid id, string name, string version, DateTime productionDate)
        {
            string generated = await _serialNumberProviderClient.GenerateAsync(
            new GenerateSerialNumberRequest(id, name, version, productionDate),true);

            Microwave microwave = Microwave.Create(id, name, version, productionDate, generated);

            await _microvaweRepository.Add(microwave);
            await _deviceRepository.Add(microwave);
        }
    }
}
