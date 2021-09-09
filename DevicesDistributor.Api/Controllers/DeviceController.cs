using System;
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

        public DeviceController(IFridgeService fridgeService)
        {
            _fridgeService = fridgeService;
        }

        [HttpPost("fridge")]
        public async Task<IActionResult> CreateFridge(CreateFridgeRequestModel createFridgeRequestModel)
        {
            Guid id = Guid.NewGuid();
            await _fridgeService.AddAsync(id, createFridgeRequestModel.Name,
                createFridgeRequestModel.Version, DateTime.UtcNow);

            return Created($"api/device/fridge/{id}",null);
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
    }
}