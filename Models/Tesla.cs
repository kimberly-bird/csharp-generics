using System;

namespace garys_generics
{
    class Tesla : IElectricPowered
    {
        public string Name { get; set; } = "Tesla";
        public double BatteryKWh { get; set; }

        public override string ToString() 
        {
            return $"{Name}";
        }
    }
}
