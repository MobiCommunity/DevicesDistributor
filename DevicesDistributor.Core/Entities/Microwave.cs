using System;

namespace DevicesDistributor.Core.Entities
{
    public class Microwave : Device
    {
        private Microwave(Guid id, string name, string version, DateTime productionDate, string serialNumber)
            : base(id, name, version, productionDate, serialNumber)
        {
        }

        internal static Microwave Create(Guid id, string name, string version, DateTime productionDate,
            string serialNumber)
        {
            Microwave microwave = new Microwave(id, name, version, productionDate, serialNumber);

            return microwave;
        }
    }
}