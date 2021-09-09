using System;

namespace DevicesDistributor.Core.Entities
{
    public abstract class Device
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Version { get; }
        public DateTime ProductionDate { get; }
        public string SerialNumber { get; }

        internal Device(Guid id, string name, string version, DateTime productionDate, string serialNumber)
        {
            Id = id;
            Name = name;
            Version = version;
            ProductionDate = productionDate;
            SerialNumber = serialNumber;
        }
    }
}