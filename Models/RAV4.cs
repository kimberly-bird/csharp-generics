using System;

namespace garys_generics
{
    class RAV4 : IGasPowered
    {
        public string Name { get; set; } = "RAV4";
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("You refueled the RAV4!");
        }
    }
}
