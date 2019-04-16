using System;
using System.Collections.Generic;

namespace garys_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla ts1 = new Tesla();
            Tesla ts2 = new Tesla();
            Tesla ts3 = new Tesla();

            RAV4 rav1 = new RAV4();
            RAV4 rav2 = new RAV4();
            RAV4 rav3 = new RAV4();

            List<IElectricPowered> electricCars = new List<IElectricPowered>(){
                ts1,
                ts2,
                ts3
            };

            List<IGasPowered> gasCars = new List<IGasPowered>(){
                rav1,
                rav2,
                rav3
            };

            BatteryStation batteryStation = new BatteryStation();

            GasStation gasStation = new GasStation();

            batteryStation.Refuel(electricCars);

            gasStation.Refuel(gasCars);

        }
    }
}
