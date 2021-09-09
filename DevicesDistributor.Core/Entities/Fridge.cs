using System;

namespace DevicesDistributor.Core.Entities
{
    public class Fridge : Device
    {
        private Fridge(Guid id, string name, string version, DateTime productionDate, string serialNumber) 
            : base(id, name, version, productionDate, serialNumber)
        {
        }

        internal static Fridge Create(Guid id, string name, string version, DateTime productionDate,
            string serialNumber)
        {
            Fridge fridge = new Fridge(id, name, version, productionDate, serialNumber);

            return fridge;
        }
    }
}