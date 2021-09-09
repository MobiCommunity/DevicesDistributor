using System;

namespace DevicesDistributor.Core.Services
{
    public class GenerateSerialNumberRequest
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Version { get; }
        public DateTime ProductionDate { get; }

        public GenerateSerialNumberRequest(Guid id, string name, string version, DateTime productionDate)
        {
            Id = id;
            Name = name;
            Version = version;
            ProductionDate = productionDate;
        }
    }
}