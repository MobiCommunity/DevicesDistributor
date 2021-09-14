using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevicesDistributor.Api.Models;
using DevicesDistributor.Core.Dtos;
using DevicesDistributor.Core.Entities;
using DevicesDistributor.Core.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DevicesDistributor.Api.Controllers
{
    [Route("api/device")]
    public class DeviceController : ControllerBase
    {
        private readonly IFridgeService _fridgeService;
        private readonly IDeviceService _deviceService;
        private readonly IMicrowaveService _microwaveService;
        
        public DeviceController(IFridgeService fridgeService, IDeviceService deviceService, IMicrowaveService microvaweService)
        {
            _fridgeService = fridgeService;
            _deviceService = deviceService;
            _microwaveService = microvaweService;
        }


        [HttpPost("fridge")]
        public async Task<IActionResult> CreateFridge([FromBody]CreateFridgeRequestModel createFridgeRequestModel)
        {
            Guid id = Guid.NewGuid();
            await _fridgeService.AddAsync(id, createFridgeRequestModel.Name,
                createFridgeRequestModel.Version, DateTime.UtcNow);

            return Created($"api/device/fridge/{id}",null);
        }


        [HttpPost("microwave")]
        public async Task<IActionResult> CreateMicrowave([FromBody] CreateMicrowaveRequestModel createMicrowaveRequestModel)
        {
            Guid id = Guid.NewGuid();
            await _microwaveService.AddAsync(id, createMicrowaveRequestModel.Name,
                createMicrowaveRequestModel.Version, DateTime.UtcNow);

            return Created($"api/device/microwave/{id}", null);
        }


        [HttpGet("fridge/{id:Guid}")]
        public async Task<IActionResult> GetFridge(Guid id)
        {
            Fridge fridge = await _fridgeService.GetAsync(id);

            if (fridge is null)
            {
                return NotFound();
            }

            return Ok(fridge.AsDto());
        }

        [HttpGet("allDevices")]
        public async Task<List<Device>> GetAllDevices()
        {
            List<Device> devices = await _deviceService.GetAllDevicesAsync();
            return devices;
        }
    }
}