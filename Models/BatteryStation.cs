using System;
using System.Collections.Generic;

namespace garys_generics
{
    class BatteryStation : IStation<IElectricPowered>
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public void Refuel(List<IElectricPowered> cars)
        {
            cars.ForEach(car => Console.WriteLine($"The {car.Name} has been charged!"));
        }
    }
}
