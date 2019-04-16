using System;
using System.Collections.Generic;

namespace garys_generics
{
    class GasStation : IStation<IGasPowered>
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public void Refuel(List<IGasPowered> cars)
        {
            cars.ForEach(car => Console.WriteLine($"The {car.Name} has been charged!"));
        }
    }
}
