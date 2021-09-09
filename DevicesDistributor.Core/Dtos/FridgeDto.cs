using System;

namespace DevicesDistributor.Core.Dtos
{
    public class FridgeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public DateTime ProductionDate { get; set; }
        public string SerialNumber { get; set; }
    }
}