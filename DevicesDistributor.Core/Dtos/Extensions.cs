using DevicesDistributor.Core.Entities;

namespace DevicesDistributor.Core.Dtos
{
    public static class Extensions
    {
        public static FridgeDto AsDto(this Fridge fridge)
        {
            return new FridgeDto
            {
                Id = fridge.Id,
                Name = fridge.Name,
                Version = fridge.Version,
                ProductionDate = fridge.ProductionDate,
                SerialNumber = fridge.SerialNumber
            };
        }

        public static DeviceDto AsDto(this Device device)
        {
            return new DeviceDto
            {
                Id = device.Id,
                Name = device.Name,
                Version = device.Version,
                ProductionDate = device.ProductionDate,
                SerialNumber = device.SerialNumber
            };
        }
    }
}